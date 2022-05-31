// zad1

$(".navbar>a").click( function()
{
    $('.navbar').children().each( function () {
        $('a').css('font-weight','normal');
        $('a').css('text-decoration', 'none')
    });
    $(this).css('font-weight','bold');
    $(this).css('text-decoration', 'underline');
})

//zad2

let  dict = new Map();
$('.fakeimg').dblclick(function ()
{
    
    if($(this).text().length > 0)
    {   if(!dict.has($(this).attr("id")))
        {
            dict.set($(this).attr("id"), $(this).text())
        }

        $(this).text("")
       
    }
    else 
    {  
        $(this).text(dict.get($(this).attr("id")));
    }
})

//zad3
let flag = false;
$(".right").click(function()
{
    
    $(document).children().each(function()
    {
        if(flag)
        {
            if($(this).css('font-weight') == 700)
            {
                $(this).css('font-weight',parseInt($(this).css('font-weight')) - 300 );
            }
             else if($(this).css('font-weight') == 900)
            {
                $(this).css('font-weight',parseInt($(this).css('font-weight')) + 200 );
            }
            
            flag = false;
        }
        else
        {
            if($(this).css('font-weight') == 400)
            {
                $(this).css('font-weight',parseInt($(this).css('font-weight')) + 300 );
            }
            else if($(this).css('font-weight') == 400)
            {
                $(this).css('font-weight',parseInt($(this).css('font-weight')) + 200 );
            }
            flag = true;
        }
    })
});

//4 

var button = $('<button> background color </button>');

let temp = 0;
$('.main>h2').hover
(function()
{
    
    console.log("here");
    $(this).append(button);
    button.click( function () {
        console.log("here");
        if (temp == 0 || temp == 2) 
        {
            $('.main>h2').css('background-color', 'red');
            temp = 1;
        }
        else if (temp == 1) 
        {
            $('.main>h2').css('background-color', 'blue');
            temp = 2;
        }
    });
},
function()
{
    $('button').remove();
});



