$('#btn').click(function()
{
    var t = $('#task-adder').val();
    $('#list').append($('<li class = " listElement ">'+t+"</li>").
    hover(
        function()
        {
            $(this).append($('<button class = "removeElement"> Remove </button>').click(function()
            {
                $(this).parent().remove();
            }));    
        },
        function()
        {
            $('> .removeElement',this).remove();
    }).click(function()
    {
        if($(this).css('text-decoration').split(' ').includes('none'))
        {
            $(this).css('text-decoration', 'line-through');
        }
        else if($(this).css('text-decoration').split(' ').includes('line-through'))
        {
            $(this).css('text-decoration', 'none');
        }
    }));


    $('#task-adder').val('');

});


