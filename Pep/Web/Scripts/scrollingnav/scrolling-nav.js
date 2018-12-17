function SetHeaderMenuCollpase()
{
    if ($('.navbar-toggle').css('display') != 'none') {

        if (!$(".workspace-content").hasClass("workspace-content-topPadding")) {
            $(".workspace-content").addClass("workspace-content-topPadding");
        }
        if (!$("#nav-header-collapse-logo").hasClass('hidden')) {
            $("#nav-header-collapse-logo").addClass("hidden");
        }
        if ($("#nav-header-collapse-menu").hasClass('col-xs-10')) {
            $("#nav-header-collapse-menu").removeClass("col-xs-10");
            $("#nav-header-collapse-menu").addClass("col-xs-12");
        }

        $(".dropdown-menu").each(function () {
            $(this).addClass("dropdown-menu-collapse");
        });

        if (!$(".navbar-nav > li").hasClass('homeSmallMenu')) {
            $(".navbar-nav > li").addClass("homeSmallMenu");
        }

        if (!$("#divOptionLinks").hasClass('hidden')) {
            $("#divOptionLinks").addClass("hidden");
        }
    }
    else {

        if ($(".workspace-content").hasClass("workspace-content-topPadding")) {
            $(".workspace-content").removeClass("workspace-content-topPadding");
        }
        if ($("#nav-header-collapse-logo").hasClass('hidden')) {
            $("#nav-header-collapse-logo").removeClass("hidden");
        }
        if ($("#nav-header-collapse-menu").hasClass('col-xs-12')) {
            $("#nav-header-collapse-menu").removeClass("col-xs-12");
            $("#nav-header-collapse-menu").addClass("col-xs-10");
        }

        $(".dropdown-menu").each(function () {
            $(this).removeClass("dropdown-menu-collapse");
        });

        if ($(".navbar-nav > li").hasClass('homeSmallMenu')) {
            $(".navbar-nav > li").removeClass("homeSmallMenu");
        }

        if ($("#divOptionLinks").hasClass('hidden')) {
            $("#divOptionLinks").removeClass("hidden");
        }
    }
}

//jQuery for page scrolling feature - requires jQuery Easing plugin
$(function () {

    $(window).resize(function () {        
        SetHeaderMenuCollpase();
        $(window).scroll();
    });    

    SetHeaderMenuCollpase();

    $('a.page-scroll').bind('click', function(event) {
        var $anchor = $(this);
        if ($anchor.attr('href') != '#') {
            $('html, body').stop().animate({
                scrollTop: $($anchor.attr('href')).offset().top
            }, 1500, 'easeInOutExpo');
        }
        
        event.preventDefault();
    });
});
