window.addEventListener('load', function(){
	new Glider(document.querySelector('.carousel__lista'), {
		slidesToShow: 1,
		dots: '.carousel__indicadores',
		duration:.10,
		arrows: {
		  prev: '.carousel__anterior',
		  next: '.carousel__siguiente'
		}
	  });
});
ScrollReveal().reveal('.carousel' ,{ reset : true }); 
ScrollReveal().reveal('.nosotros',{ delay: 300 , reset : true });  
ScrollReveal().reveal('.card',{ delay: 300 , reset : true});  
     
     let btnbar = document.querySelector('.bar');
        btnbar.addEventListener('click',()=>{
                document.querySelector('.nav').classList.toggle('show');
        })
       
       let btncat=document.querySelector('.catalogo');
        btncat.addEventListener('click',()=>{
                document.querySelector('.nav-ul-sub').classList.toggle('show');
        })

  
   