$(".play_list ul li").click(function(){
    $("audio").attr("src", songs[$(this).index()].path);
    audio.play();
    alert(1);
    sv();
})



