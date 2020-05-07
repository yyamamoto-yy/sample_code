/* acordion1 */

  function toggleChevron(e) {
  $(e.target)
  .prev('.panel-heading')
  .find("i.indicator")
  .toggleClass('glyphicon-chevron-down-custom glyphicon-chevron-up-custom');
          }
          $('#accordion').on('hidden.bs.collapse', toggleChevron);
          $('#accordion').on('shown.bs.collapse', toggleChevron);

/* acordion2 */
$(".accordion-wrap").on("click", function(){
    $(this).children().eq(1).slideToggle(300);
    $(this).children().eq(0).toggleClass("accordion-no-bar");
    $(this).siblings().find(".accordion-header").removeClass("accordion-gold");
    $(this).siblings().find(".accordion-header i").removeClass("rotate-fa");
    $(this).find(".accordion-header").toggleClass("accordion-gold");
    $(this).find(".fa").toggleClass("rotate-fa");

    $(".accordion-wrap .accordion-text").not($(this).children().eq(1)).slideUp(300);
});
