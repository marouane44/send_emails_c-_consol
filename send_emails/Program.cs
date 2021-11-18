using System;
using System.ComponentModel;
using System.Net;

using System.Net.Mail;
namespace send_emails
{
    class Program
    {
       public   
      
       
        static void Main(string[] args)
        {
            var class1 = new Class1();
            class1.ff();

        }
    
        class Class1
        {
           
            public void ff()
            { MailMessage message;
            SmtpClient smtp;
                try {
                message = new MailMessage();
              
               
           
                message.From = new MailAddress("bouchraalghazali8@gmail.com");//"bouchra__@??LK88"
               
                    for(int i=0; i < 1; i++)
                    {
                     message.To.Add("marwanhaz43@gmail.com");
                    }
          
                    message.Subject = "test"; 
                    message.IsBodyHtml = true;
                    string hh = @"<table style=""background-repeat:repeat-x"" width=""100%"" height=""100%"" cellpadding=""10"" cellspacing=""0"" background=""https://ci4.googleusercontent.com/proxy/hMxAthgOl0ES6J--gtDCKi6NFkB9re6ANU40R3DicN6uG56xawELEKzMQKs-8BdCvbcXjygAwTtVg_6MOjckCYuERs9NV57l=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/blue_bg.gif"" bgcolor=""#378ddc"">
<tbody><tr>
<td valign=""top"" align=""center""><table width=""650"" cellpadding=""0"" cellspacing=""0"">
  <tbody><tr>
    <td height=""30"" align=""center"">&nbsp;</td>
  </tr>
  </tbody></table>
  
    
  <table width=""650"" cellpadding=""0"" cellspacing=""0"" bgcolor=""#FFFFFF"">
    <tr>
      
      <td width=""310"" align=""ltop-left"" valign=""middle""><img src=""https://ci5.googleusercontent.com/proxy/gJ0JSBXpPHLvGjDR-7ELm3U5UYQPxXrbcqtxWqiN6AvprqD9t9lZWPNBDLhTumuk6A7-XSPRRkh5gjDozQ=s0-d-e1-ft#https://i.postimg.cc/9QrXcFyx/hdr-logo.png"" alt=""Your Business Name"" width=""300"" height=""150"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 722px; top: 240px;""><div id="":259"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V"" data-tooltip=""Download""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
     
    </tr>
  
 </table>
    
  
  <table width=""650"" cellpadding=""0"" cellspacing=""0"">
    <tbody><tr>
      <td><img src=""https://ci6.googleusercontent.com/proxy/AQZvNXepgBAFPp_LuuPFtg9QQs6vXSoFvBRe35v66gmzp5JyJ2XMGf95-sKv7b6CVYWrC75ujsCGWIogqGGsprTm1xiR1wYbTrH6mW0=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/shadow_large.png"" width=""650"" height=""10"" border=""0"" style=""display:block"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
    </tr>
    <tr>
      <td height=""10""></td>
    </tr>
  </tbody></table>
  
  
  <table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td align=""center""><img src=""https://ci6.googleusercontent.com/proxy/tyF9eJxLMFsGAl3sVX2jkrKIzfCeD-TvMZfi6THaFvmiGaOsMKLR6ZOp_opflwCW-qGjs4jQb-8-Fg=s0-d-e1-ft#https://i.postimg.cc/2jq0ddk2/giphy.gif"" width=""620"" height=""220"" alt=""header"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 1042px; top: 510px;""><div id="":25g"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V"" data-tooltip=""Download""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
  </tr>
</tbody></table>



<table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td width=""149"" valign=""top"" style=""font-size:12px;color:rgb(122,122,122);line-height:150%;font-family:trebuchet ms""><table width=""125"" cellpadding=""0"" cellspacing=""0"">
      <tbody><tr>
        <td>
      
          <img src=""https://ci5.googleusercontent.com/proxy/HvEHuu6c0XEhJy-Nr5fDjsO_LCT3P2LD970H0-3IKBmuKPeiRnZwX31fnVoAvDIhJEEGvqSa=s0-d-e1-ft#https://i.postimg.cc/yxcRW8mC/1.jpg"" alt=""Advertistment"" width=""125"" height=""125"" border=""0"" style=""display:block"" class=""CToWUd""><br>
          <img src=""https://ci4.googleusercontent.com/proxy/8w_18ofMHmPqswBkpMJ4x1HeluhMIh46iNlveLmNqWznwUZFHECW0AId7hgekapjJradLgsIQDE=s0-d-e1-ft#https://i.postimg.cc/rpjQFQ8N/EPI.jpg"" alt=""Advertistment"" width=""125"" height=""125"" border=""0"" style=""display:block"" class=""CToWUd""><br>
          <img src=""https://ci3.googleusercontent.com/proxy/EQ6_FttT3cGs-5EYybyCwSVZe6pjG_g373dDZeCILNB2xeRb50b9k3SDLm8n3dVUWbydVHmHmptkvQp75A=s0-d-e1-ft#https://i.postimg.cc/mkHnDCpZ/download.jpg"" alt=""Advertistment"" width=""125"" height=""125"" border=""0"" style=""display:block"" class=""CToWUd""><br>
          <img src=""https://ci6.googleusercontent.com/proxy/2zkPJc3vOrqKXiEZw-BA4dvPKqWz3oG1UndfvHFixcYk5h7m6yHzEN7YkmVqT4J92K93wQawvw57=s0-d-e1-ft#https://i.postimg.cc/cJkkBXV4/DTEC.png"" alt=""Advertistment"" width=""125"" height=""125"" border=""0"" style=""display:block"" class=""CToWUd""></td>
      </tr>
    </tbody></table></td>
    <td width=""1"" valign=""middle""><img src=""https://ci4.googleusercontent.com/proxy/X2K1lF7FKEAYGoBI6_e1v9PPWiScZQhtARyaiLhtLpxZlSXBnMJihfK0U9wGgKzNCP6Cun1ia7xHnmMkkylerH-ewArEbG7urBs=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/sep_large.gif"" width=""1"" height=""650"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
    <td width=""500"" valign=""top"" style=""font-size:12px;color:rgb(122,122,122);line-height:150%;font-family:trebuchet ms"">
      <table width=""420"" border=""0"" cellpadding=""0"" valign=""top"" cellspacing=""0"">
      <tbody><tr>
        <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif;line-height:110%"">À propos de nous</span></td>
      </tr>
      <tr>
        <td><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">Afayad est un groupe basée sur marrakech spécialisé dans l'hygiène,traitement,sécurité,<wbr>prévention contre incendie ainsi que des analyses industrielles de qualité assurées par notre équipe hautement qualifée.Afayad vous propose également des services de formations d'hygiène,sécurité d'incendie (sensibilation à la manipulation des extincteurs) et des formations de secourisme(initiation aux premiers secours).Depuis le début de notre activité en 2002,on a pu entretenir une large base de clients satisfaits et fidèle a nos prestations,grâce a notre équipe ponctuelle et détérminée à améliorer ses potentialités  pour satisfaire les attentes de nos clients.
<br>
        </span><br></td>
      </tr>
      <tr>
        <td align=""right""></td>
      </tr>
      <tr>
        <td height=""25"" valign=""top""><span style=""font-size:12px;color:rgb(122,122,122)""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif;line-height:110%"">équipement anti-incendie</span><br>
        </span></td></tr>
      <tr>
        <td><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">Les incendies causent annuellement des dégâts matériels et humains irrémédiables.Afayad vous propose un processus de détection,protection et prévention contre incendie a l'aide des matiériels de haute qualité et se charge de leurs installations  .Des extincteurs,détecteurs de fumée,RIA et d'autres, pour un usage régulier ou moins fréquent ,afin d éviter la début des incendies et limiter les dégâts de leurs propagations.
          You can alsh this awesome email template. </span></td>
      </tr>
      <tr>
        <td align=""right"">  </td>
      </tr>
      <tr>
        <td><br>
          <img src=""https://ci5.googleusercontent.com/proxy/x_ondkPYmz26iAQJnYAHXTqJfma4QCm3yfsHV9_hewJkSYJ7vZ2aB9FR--nH-9wf4BYlLspm=s0-d-e1-ft#https://i.postimg.cc/vZGDyzDz/2.jpg"" alt=""Image"" width=""420"" height=""260"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 1031.22px; top: 1215px;""><div id="":25e"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" title=""Download"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div><br>
          <br></td>
      </tr>
      <tr>
        
      </tr><tr>
        <td align=""right""></td>
      </tr>
    </tbody></table></td>
  </tr>
</tbody></table>
 
 
<table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td align=""center""><table width=""610"" cellpadding=""0"" cellspacing=""0"">
      <tbody><tr>
        
      </tr>
      <tr>
        
        
      </tr>
    </tbody></table></td>
  </tr>
</tbody></table>


<table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td align=""center""><table width=""610"" cellpadding=""0"" cellspacing=""0"">
      <tbody><tr>
        <td width=""300"" height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif;line-height:110%"">Matériels de désinfection</span></td>
        <td width=""10""></td>
        <td width=""300"" height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif;line-height:110%"">Materiels anti-insectes</span></td>
      </tr>
      <tr>
        <td height=""10"" valign=""top""><img src=""https://ci6.googleusercontent.com/proxy/CUCNvLtppQfxswlxvksZrW-EgxPNQjb2MrjFtA248u5dJk4SSkaZOZFKTvzsNZXm-5kEOWB3AqVCCKVXpM_hKJrXVcsq8HCxBny8aRXVCgMLwJtIKw=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/sep_large_horizontal.gif"" alt="""" width=""290"" height=""1"" border=""0"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
        <td valign=""top""></td>
        <td height=""10"" valign=""top""><img src=""https://ci6.googleusercontent.com/proxy/CUCNvLtppQfxswlxvksZrW-EgxPNQjb2MrjFtA248u5dJk4SSkaZOZFKTvzsNZXm-5kEOWB3AqVCCKVXpM_hKJrXVcsq8HCxBny8aRXVCgMLwJtIKw=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/sep_large_horizontal.gif"" alt="""" width=""300"" height=""1"" border=""0"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
      </tr>
      <tr>
        <td width=""300"" valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">La désinfection des locaux et l'une de nos missions principale que nous assurons avec haute attentivité.Ceci des devenus primordiale après la propagation de l'épidémie du Covid 19 dans notre pays,a Marrakech plus particulièrement étant une ville touristique qui necessite un traiement attentif plus ou moins réguliers.C'est pour cela que nous traitons vos locaux(occasionellement,<wbr>mentuellement) suivants des instructions et des normes bien precises</span></td>
        <td width=""10"" valign=""top"">&nbsp;</td>
        <td width=""300"" valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">Que ca soit pour vos logements,hotels,riads ou milieu de travail,les insectes sont genants et desagreables a voir.Allergie,transmission des bacteries allant jusqu'a creer de graves problemes d'infections de la peau ,les insectes peuvent également causer des dégats considérables aux habitations.Nous proposons a l'addition e nos services anterieurement mentionnés un deratisation;desinsectisation pour vos locaux,avant leurs aggravations. </span></td>
      </tr>
    </tbody></table></td>
  </tr>
</tbody></table>






<table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td align=""center"">
        <table width=""610"" cellpadding=""0"" cellspacing=""0"">
      <tbody><tr>
        <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif;line-height:110%"">Image Gallary</span></td>
      </tr>
      <tr>
        <td height=""10"" valign=""top""><img src=""https://ci6.googleusercontent.com/proxy/CUCNvLtppQfxswlxvksZrW-EgxPNQjb2MrjFtA248u5dJk4SSkaZOZFKTvzsNZXm-5kEOWB3AqVCCKVXpM_hKJrXVcsq8HCxBny8aRXVCgMLwJtIKw=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/sep_large_horizontal.gif"" alt="""" width=""610"" height=""1"" border=""0"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
      </tr>
    </tbody></table>
      <table width=""610"" border=""0"" cellpadding=""0"" cellspacing=""0"">
        <tbody><tr>
          <td width=""200"" style=""font-size:12px;color:rgb(122,122,122)""><img src=""https://ci4.googleusercontent.com/proxy/c-bouB3V0J-vm1sJ2Y4zOdDjbO9L0YAyVPcyOI1CrD5Juak44U8zGr3i8FeBVEJD8LIStyya3GAit9Plw8ga=s0-d-e1-ft#https://i.postimg.cc/8zYSQz8b/extincteur.jpg"" alt=""Image"" width=""200"" height=""200"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 627px; top: 1805px;""><div id="":25b"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V"" data-tooltip=""Download""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
          <td width=""5"" style=""font-size:12px;color:rgb(122,122,122)"">&nbsp;</td>
          <td width=""200"" style=""font-size:12px;color:rgb(122,122,122)""><img src=""https://ci5.googleusercontent.com/proxy/qus7OpVhdv1JWn9jD996bNXeCcSfJvngYKkE_0gF-gogLHDElnBOWHjNDa1u6eaOqqNVMn5s3cKG=s0-d-e1-ft#https://i.postimg.cc/NGzH51w8/riaa.jpg"" alt=""Image"" width=""200"" height=""200"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 832px; top: 1805px;""><div id="":25d"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" title=""Download"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
          <td width=""5"" style=""font-size:12px;color:rgb(122,122,122)"">&nbsp;</td>
          <td width=""200"" style=""font-size:12px;color:rgb(122,122,122)""><img src=""https://ci4.googleusercontent.com/proxy/u3dZsBskeWedlZiHD92z4vjSA7INdEc-S_V6S8dGs9Tsm4XlKcRAY_egqNaTc-G6--H5Mb-1faK2diM1cXIVyG9E=s0-d-e1-ft#https://i.postimg.cc/mDPGVdbV/detecteur-fum.jpg"" alt=""Image"" width=""200"" height=""200"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 1037px; top: 1805px;""><div id="":25f"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V"" data-tooltip=""Download""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif"">Extincteur</span></td>
          <td></td>
          <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif"">RIA</span></td>
          <td></td>
          <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif"">Détecteur de fumée<br>
          </span></td>
        </tr>
        <tr>
          <td valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif""> </span></td>
          <td>&nbsp;</td>
          <td valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">.</span></td>
          <td>&nbsp;</td>
          <td valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">
        </span></td></tr><tr>
          <td><br>
            <table width=""200"" border=""0"" cellpadding=""0"" cellspacing=""0"">
              <tbody><tr>
                <td width=""100""> </td>
                <td width=""100"" align=""center""><span style=""font-size:14px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">  </span><span style=""font-size:18px;color:rgb(215,3,3);font-family:Helvetica,Arial,sans-serif;font-weight:bold""> </span></td>
              </tr>
            </tbody></table></td>
          <td>&nbsp;</td>
          <td><br>
            <table width=""200"" border=""0"" cellpadding=""0"" cellspacing=""0"">
              <tbody><tr>
                <td width=""100""> </td>
                <td width=""100"" align=""center""><span style=""font-size:14px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif""> </span><span style=""font-size:18px;color:rgb(215,3,3);font-family:Helvetica,Arial,sans-serif;font-weight:bold"">.</span></td>
              </tr>
            </tbody></table></td>
          <td>&nbsp;</td>
          <td><br>
            <table width=""200"" border=""0"" cellpadding=""0"" cellspacing=""0"">
              <tbody><tr>
                <td width=""100""> </td>
                <td width=""100"" align=""center""><span style=""font-size:14px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">  </span><span style=""font-size:18px;color:rgb(215,3,3);font-family:Helvetica,Arial,sans-serif;font-weight:bold"">.</span></td>
              </tr>
            </tbody></table></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td width=""200"" style=""font-size:12px;color:rgb(122,122,122)""><img src=""https://ci4.googleusercontent.com/proxy/_hcbrDySfB1UXt-s9KXQTlbXooXuyPHfd6O9mmo56bkrcA8Sg9lPNcyxe_Tt948Il6meHb1T_-UfRg=s0-d-e1-ft#https://i.postimg.cc/C5fw7wGc/firee.jpg"" alt=""Image"" width=""200"" height=""200"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 627px; top: 2140px;""><div id="":25c"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V"" data-tooltip=""Download""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
          <td width=""5"" style=""font-size:12px;color:rgb(122,122,122)"">&nbsp;</td>
          <td width=""200"" style=""font-size:12px;color:rgb(122,122,122)""><img src=""https://ci6.googleusercontent.com/proxy/n579he629SPMSuYUHzgi_VZLsWElp8QGurmTVGzLR37gzY5ql1UMGsIxecboAbjRdYromZKxdd5mOttbH_ctXrOb6jU=s0-d-e1-ft#https://i.postimg.cc/htGQ8dJs/tuyeau-incendie.jpg"" alt=""Image"" width=""200"" height=""200"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 832px; top: 2140px;""><div id="":257"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V"" data-tooltip=""Download""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
          <td width=""5"" style=""font-size:12px;color:rgb(122,122,122)"">&nbsp;</td>
          <td width=""200"" style=""font-size:12px;color:rgb(122,122,122)""><img src=""https://ci4.googleusercontent.com/proxy/eIVp1yM6rot2Fe2QOBWVggIGhgHIFKZMhYtOYqa9sbaa3Y4PWMbufeudUPAZSO0XlWsxh5m3RC4PtzvKAzCQmCU=s0-d-e1-ft#https://i.postimg.cc/7Lk88ggM/robinetterie.jpg"" alt=""Image"" width=""200"" height=""200"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 1037px; top: 2140px;""><div id="":258"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" title=""Download"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif"">Plaque signalétique</span></td>
          <td></td>
          <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif"">Tuyau incendie</span></td>
          <td></td>
          <td height=""25"" valign=""top""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif"">Robinetterie<br>
          </span></td>
        </tr>
        <tr>
          <td valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif""> </span></td>
          <td>&nbsp;</td>
          <td valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif""></span></td>
          <td>&nbsp;</td>
          <td valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif""></span></td>
        </tr>
        <tr>
          <td><br>
            <table width=""200"" border=""0"" cellpadding=""0"" cellspacing=""0"">
              <tbody><tr>
                <td width=""100""> </td>
                <td width=""100"" align=""center""><span style=""font-size:14px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">  </span><span style=""font-size:18px;color:rgb(215,3,3);font-family:Helvetica,Arial,sans-serif;font-weight:bold"">  </span></td>
              </tr>
            </tbody></table></td>
          <td>&nbsp;</td>
          <td><br>
            <table width=""200"" border=""0"" cellpadding=""0"" cellspacing=""0"">
              <tbody><tr>
                <td width=""100""> </td>
                <td width=""100"" align=""center""><span style=""font-size:14px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">  </span><span style=""font-size:18px;color:rgb(215,3,3);font-family:Helvetica,Arial,sans-serif;font-weight:bold"">.</span></td>
              </tr>
            </tbody></table></td>
          <td>&nbsp;</td>
          <td><br>
            <table width=""200"" border=""0"" cellpadding=""0"" cellspacing=""0"">
              <tbody><tr>
                <td width=""100""></td>
                <td width=""100"" align=""center""><span style=""font-size:14px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">  </span><span style=""font-size:18px;color:rgb(215,3,3);font-family:Helvetica,Arial,sans-serif;font-weight:bold"">.</span></td>
              </tr>
            </tbody></table></td>
        </tr>
    
   

   
      </tbody></table>
      </td>
  </tr>
</tbody></table>


<table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td align=""center"">
       

    <table width=""610"" cellpadding=""0"" cellspacing=""0"">
      <tbody><tr></tr></tbody></table></td>
  </tr>
</tbody></table>






<table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td align=""center""><table width=""610"" cellpadding=""0"" cellspacing=""0"">
      <tbody><tr>
        <td width=""400""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif;line-height:110%"">3/4 Analyses industrielles et traitement des eaux</span></td>
        <td width=""10""></td>
        <td width=""200""><span style=""font-size:18px;color:rgb(51,51,60);font-family:Helvetica,Arial,sans-serif;line-height:110%"">  </span></td>
      </tr>
      <tr>
        <td width=""400""><img src=""https://ci6.googleusercontent.com/proxy/CUCNvLtppQfxswlxvksZrW-EgxPNQjb2MrjFtA248u5dJk4SSkaZOZFKTvzsNZXm-5kEOWB3AqVCCKVXpM_hKJrXVcsq8HCxBny8aRXVCgMLwJtIKw=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/sep_large_horizontal.gif"" alt="""" width=""400"" height=""1"" border=""0"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
        <td valign=""top"">&nbsp;</td>
        <td width=""200""><img src=""https://ci6.googleusercontent.com/proxy/CUCNvLtppQfxswlxvksZrW-EgxPNQjb2MrjFtA248u5dJk4SSkaZOZFKTvzsNZXm-5kEOWB3AqVCCKVXpM_hKJrXVcsq8HCxBny8aRXVCgMLwJtIKw=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/sep_large_horizontal.gif"" alt="""" width=""200"" height=""1"" border=""0"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
      </tr>
      <tr>
        <td width=""400"" valign=""top""><table width=""400"" cellpadding=""0"" cellspacing=""0"">
          <tbody><tr>
            <td width=""150"" valign=""top""><span style=""font-size:12px;color:rgb(122,122,122)""><img src=""https://ci5.googleusercontent.com/proxy/PTtxjkXvzi0xYx9tea6WYiL2EEdH8VoqmrgiMNWUTFHpb0ii7nqK6zWvx7JLZGieX6UpyorjNvzYD5cx5Mgg8A=s0-d-e1-ft#https://i.postimg.cc/59q1m9Fk/eau-analyse.jpg"" alt=""Image"" width=""150"" height=""150"" border=""0"" class=""CToWUd a6T"" tabindex=""0""><div class=""a6S"" dir=""ltr"" style=""opacity: 0.01; left: 577px; top: 2524px;""><div id="":25a"" class=""T-I J-J5-Ji aQv T-I-ax7 L3 a5q"" title=""Download"" role=""button"" tabindex=""0"" aria-label=""Download attachment "" data-tooltip-class=""a1V""><div class=""akn""><div class=""aSK J-J5-Ji aYr""></div></div></div></div></span></td>
            <td width=""5"" valign=""top""><p><br>
            </p></td>
            <td width=""245"" valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">Les services  .<br>
              <br>
              analyses de l’eau dans les ressources ou les eaux résiduaires à traiter ;<br>
              analyses de réception d’une installation permettant la vérification de ses performances ;<br>
              analyses de suivi d’une exploitation démontrant le respect à tout moment des normes la concernant…</span></td>
          </tr>
        </tbody></table></td>
        <td valign=""top"">&nbsp;</td>
        <td width=""200"" valign=""top""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif""> 
            
            
            <img src=""https://i.ibb.co/k6CvDG9/88888.png"" width=""240ox"" alt=""88888"" border=""0""><br />
            
            <br>
          <br>
             </span></td>
      </tr>
    </tbody></table></td>
  </tr>
</tbody></table>







<table width=""650"" cellpadding=""15"" cellspacing=""0"" bgcolor=""#FFFFFF"">
  <tbody><tr>
    <td width=""310""><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">Copyright © 2020 Company Name :AFAYAD GROUPE<br>
      40000 Marrakech AV Allal El Fassi  | 4 eme etage b 30 +212 6-63-63-08-08 <a href=""mailto:you@yoursite.com"" target=""_blank"">afayadgroupe@hotmail.fr</a> </span>
      <p><span style=""font-size:12px;color:rgb(122,122,122);font-family:Helvetica,Arial,sans-serif"">This email was sent to you from: <a style=""color:#3185c4;text-decoration:none"" href=""#m_-3840383144034134317_"">afayadgroupe@hotmail.fr</a></span></p></td>
    <td align=""right"" bgcolor=""#FFFFFF"" valign=""bottom"" width=""278""><table width=""155"" cellpadding=""5"" cellspacing=""0"">
      <tbody><tr>
      </tr>
      <tr>
        
      </tr>
    </tbody></table></td>
  </tr>
</tbody></table>


<table width=""650"" cellpadding=""0"" cellspacing=""0"">
  <tbody><tr>
    <td><img src=""https://ci6.googleusercontent.com/proxy/AQZvNXepgBAFPp_LuuPFtg9QQs6vXSoFvBRe35v66gmzp5JyJ2XMGf95-sKv7b6CVYWrC75ujsCGWIogqGGsprTm1xiR1wYbTrH6mW0=s0-d-e1-ft#http://../../tf_graphics/email_temp_a/img/shadow_large.png"" width=""650"" height=""10"" border=""0"" style=""display:block"" class=""CToWUd"" jslog=""138226; u014N:xr6bB; 53:W2ZhbHNlXQ..""></td>
  </tr>
  <tr>
    <td height=""10""></td>
  </tr>
</tbody></table>
<table width=""650"" cellpadding=""0"" cellspacing=""0"">
  <tbody><tr>
    <td width=""310"" align=""center""><span style=""font-size:12px;color:rgb(000,000,000);font-family:Helvetica,Arial,sans-serif""><a style=""color:#ffffff"" href=""#m_-3840383144034134317_"">Unsubscribe</a> l <a style=""color:#ffffff"" href=""#m_-3840383144034134317_"">Subscribe</a></span></td>
  </tr>
</tbody></table><p>&nbsp;</p></td>
</tr>
</tbody></table>"" ";
                    message.Body =hh;
                  
                smtp = new SmtpClient("");

                smtp.Port = 587;
                 smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("bouchraalghazali8@gmail.com", "bouchra__@??LK88");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    Console.Title = "ASCII Art";
                    string title = @"      
               .s$$$s.
              $$$$$$$$s.
             $$$' $$`$$$s
            $$; ~ $$~`$;$
            $;$ o> $o  $$;
           `;$$$  .\s.,$$,
           ;$$$\`-=-  /$;`
             '' |.__,||
                |    '|=-.__
           ,-=-';`    |     `.
          (          /|       \
           :      ,   ;   |\   \
           ;             :; `.  \
          :o)  ; :  (o  ;:    \  \
      ,---`.__    `.__,' |     \/ }
      | }-' |         / |     ; /
      '\U)   |         / ;    / /
        ^\   | :        :_,-= '_;
          \  ; c,__V`
           \/     .     /:
           ;\          / \
          :  \`*= ---= */   :
          |   \Wild~@/     :
          ;    \Love /      `
         /      > -./        `
        /       /  `.        \
       /      ,'     `.       \
      :      /         `.      \
     ;      /            `.     \
    {  )   /               `.    `.
    ;    ,'                  \ \ \ \
   |    :                     `.    \
   :    |                       \    \
  :     |                        \    \
  |     |                         \    \
  |     :                          `.   :
  |    :                             \   :
  |    ;                              \  :
  :   /                                \ ,]
  [==:                                 :== \
  |   `),                              | \  \
  t -+= y'                               `. +<>
    | [ |                                  | \ \

    | _ | | osfa |\ \ \";

                    Console.WriteLine(title);
                    // smtp.Credentials = new NetworkCredential();

                    //  smtp.SendAsync(message, message.Subject);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
              //  smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
            }

            //void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)

            //{

            //    if (e.Cancelled == true)

            //    {

            //        Console.WriteLine("uuuuuuuuuuuuuuuuu");

            //    }

            //    else if (e.Error != null)

            //    {

            //        Console.WriteLine("iiiiiiiiiiiiiiiiiiii");

            //    }

            //    else

            //    {


            //        Console.WriteLine("ssssss");

            //    }





            //}

        }
        }
}
