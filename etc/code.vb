function m()
	dim cs
	dim list
	list = ""
	set cs = cp.csNew()
	if not cs.open("image fader images", "" ,"sortOrder") then
		'
	else
		do while cs.ok()
			list = list _
				& vbcrlf & "<li>" _
				& vbcrlf & vbcrlf & "<img class=""ifImage"" src=""" & cp.site.filePath & cs.getText( "imageFilename" ) & """>" _
				& vbcrlf & vbcrlf & "<div class=""ifText"">" _
				& vbcrlf & vbcrlf & vbcrlf & "<h1>" & cs.getText("headline") & "</h1>" _
				& vbcrlf & vbcrlf & vbcrlf & "<p>" & cs.getText("copy") & "</p>" _
				& vbcrlf & vbcrlf & "</div>" _
				& vbcrlf & "</li>" _
				& ""
			call cs.gonext()
		loop
	end if
	call cs.close()
	list = "" _
		& vbcrlf & "<ul id=""imageFader"">" _
		& cp.html.indent( list, 1 ) _
		& vbcrlf & "</ul>"
	m = list
end function