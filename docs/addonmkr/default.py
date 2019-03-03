#!/usr/bin/python
# -*- coding: utf-8 -*-
import xbmcplugin,xbmcaddon,xbmcgui,xbmc,urllib,urllib2,os,sys
from bs4 import BeautifulSoup

addon = xbmcaddon.Addon()
addon_path = addon.getAddonInfo('path').decode('utf-8')
xbmcplugin.setContent(handle=int(sys.argv[1]), content='tvshows')

video_data_url ='http://xxx/xxx/xxx/data.txt'

def open_url(url):
    try:
        req = urllib2.Request(url)
        req.add_header('User-Agent', 'Mozilla/5.0 (Windows; U; Windows NT 5.1; en-GB; rv:1.9.0.3) Gecko/2008092417 Firefox/3.0.3')
        response = urllib2.urlopen(req)
        r=response.read()
        response.close()
        return r
    except urllib2.HTTPError, e:
        xbmcgui.Dialog().ok('HTTP Error !', str(e))
        sys.exit()
	
def beautiful_soup_ytpl(r_read):
	
    soup = BeautifulSoup(r_read)
    for li in soup.findAll('li'):
	
        if li:
            video_titel = li.get('data-video-title')
            video_id = li.get('data-video-id')
			
            img = li.find('img')
            if img:
                video_img = img.get('src')
                if not 'jpg' in video_img:
                    video_img = img.get('data-thumb')

                if ((not video_titel == None) and (not video_id == None)):
                    play_url = 'plugin://plugin.video.youtube/?action=play_video&videoid=%s' % video_id
                    addItem(play_url,{'title':'[COLOR white]' + video_titel + '[/COLOR]'}, video_img)
					
def beautiful_soup_thumbnail(r_read):

    soup = BeautifulSoup(r_read)
    for li in soup.findAll('link'):
        if li:
            if 'thumbnailUrl' in str(li.get('itemprop')):
                return li.get('href')

def addDir(name,url,mode,iconimage):
        u=sys.argv[0]+'?url='+str(url)+'&mode='+str(mode)+'&name='+str(name)
        liz=xbmcgui.ListItem(name, iconImage='DefaultFolder.png', thumbnailImage=iconimage)
        liz.setInfo( type='Video', infoLabels={ 'Title': name } )
        ok=xbmcplugin.addDirectoryItem(handle=int(sys.argv[1]),url=u,listitem=liz,isFolder=True)

def addItem(url, infolabels, img):
    listitem = xbmcgui.ListItem(infolabels['title'], iconImage='DefaultVideo.png', thumbnailImage=img)
    listitem.setInfo('video', infolabels)
    listitem.setProperty('IsPlayable', 'true')
    ok=xbmcplugin.addDirectoryItem(int(sys.argv[1]), url, listitem)

if not sys.argv[2] == '' and 'url=' in sys.argv[2]:
    beautiful_soup_ytpl(open_url(urllib.unquote(sys.argv[2].split('url=')[1]).decode('utf8')))
else:
    if os.path.exists(os.path.join(addon_path,'data.txt')):
        f = open(os.path.join(addon_path,'data.txt'),'r')
        for line in f.readlines():
            line = line.decode('ISO-8859-1', 'ignore').encode('utf-8').strip()
            try:
                my_name,my_url = line.split('*')
                if 'https://www.youtube.com' in my_url and 'watch?v=' in my_url and '&list=' in my_url:
                    video_thumbnail = beautiful_soup_thumbnail(open_url(my_url))
                    addDir('[COLOR blue]' + my_name + '[/COLOR]', urllib.quote(my_url).encode('utf8'), 1, video_thumbnail)
                elif 'https://www.youtube.com' in my_url and 'watch?v=' in my_url and not '&list=' in my_url:
                    video_thumbnail = beautiful_soup_thumbnail(open_url(my_url))
                    addItem('plugin://plugin.video.youtube/?action=play_video&videoid=%s' % my_url.split('watch?v=')[1], {'title':'[COLOR red]' + my_name + '[/COLOR]'},video_thumbnail)
            except ValueError, e:
                    xbmcgui.Dialog().ok('Split Value Error !', str(e))
                    sys.exit()
        f.close()
    else:
        try:
            for line in urllib2.urlopen(video_data_url):
                line = line.decode('ISO-8859-1', 'ignore').encode('utf-8').strip()
                try:
                    my_name,my_url = line.split('*')
                    if 'https://www.youtube.com' in my_url and 'watch?v=' in my_url and '&list=' in my_url:
                        video_thumbnail = beautiful_soup_thumbnail(open_url(my_url))
                        addDir('[COLOR blue]' + my_name + '[/COLOR]', urllib.quote(my_url).encode('utf8'), 1, video_thumbnail)
                    elif 'https://www.youtube.com' in my_url and 'watch?v=' in my_url and not '&list=' in my_url:
                        video_thumbnail = beautiful_soup_thumbnail(open_url(my_url))
                        addItem('plugin://plugin.video.youtube/?action=play_video&videoid=%s' % my_url.split('watch?v=')[1], {'title':'[COLOR red]' + my_name + '[/COLOR]'}, video_thumbnail)
                except ValueError, e:
                    xbmcgui.Dialog().ok('Split Value Error !', str(e))
                    sys.exit()
        except urllib2.HTTPError, e:
            xbmcgui.Dialog().ok('HTTP Error !', str(e))
            sys.exit()

xbmcplugin.endOfDirectory(int(sys.argv[1]))
xbmc.executebuiltin('Container.SetViewMode(100)')