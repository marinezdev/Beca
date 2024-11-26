using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Application
{
    public class Usuarios
    {
		public Models.Mensaje UsuarioAgregar(Models.Usuario usuario)
		{
			Models.Mensaje mensaje = new Models.Mensaje();

			
			WSCorreo.CorreoSoapClient correo1 = new WSCorreo.CorreoSoapClient();

			// MANDAR CORREO 
			mensaje.Respuesta = 1;

			if (correo1.CorreoMetPrivado("mail.asae.com.mx", 25, "soporte-aplicaciones@asae.com.mx", "$%65hgy#19_", usuario.email, "Seguros BECA", "Cotización ", NewUserHTML(usuario)) == "Correo enviado")
			{
				mensaje.RespuestaText = "Se ha enviado un correo electrónico a " + mensaje.Email + ".";
			}

			return mensaje;
		}

		private string NewUserHTML(Models.Usuario usuario)
		{
			string body = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>" +
                    "<html xmlns:v='urn:schemas-microsoft-com:vml'>" +
                    "<head>" +
                        "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />" +
                        "<meta name='viewport' content='width=device-width; initial-scale=1.0; maximum-scale=1.0;' />" +
                        "<!--[if !mso]--><!-- -->" +
                        "<link href='https://fonts.googleapis.com/css?family=Nunito+Sans:200,300,400,600,700' rel='stylesheet'>" +
                        "<!--<![endif]-->" +
                        "<title>Asae Consultores S.A de C.V</title>" +
                        "<style type='text/css'>" +
                            "body {" +
                                "width: 100%;" +
                                "background-color: #ffffff;" +
                                "margin: 0;" +
                                "padding: 0;" +
                                "-webkit-font-smoothing: antialiased;" +
                                "mso-margin-top-alt: 0px;" +
                                "mso-margin-bottom-alt: 0px;" +
                                "mso-padding-alt: 0px 0px 0px 0px;" +
                                "font-family: 'Proxima Nova',-apple-system,'Helvetica Neue',Helvetica,Roboto,Arial,sans-serif;" +
                            "}" +
                            "* {" +
                                "-ms-text-size-adjust: 100%;" +
                                "-webkit-text-size-adjust: 100%;" +
                            "}" +
                            "div[style*='margin: 16px 0'] {" +
                                "margin: 0 !important;" +
                            "}" +

                            "table," +
                            "td {" +
                                "mso-table-lspace: 0pt !important;" +
                                "mso-table-rspace: 0pt !important;" +
                            "}" +

                            "table {" +
                                "border-spacing: 0 !important;" +
                                "border-collapse: collapse !important;" +
                                "table-layout: fixed !important;" +
                                "margin: 0 auto !important;" +
                            "}" +

                            "img {" +
                                "-ms-interpolation-mode:bicubic;" +
                            "}" +
                            "a {" +
                                "text-decoration: none;" +
                            "}" +
                            "h1, h2, h3, h4, h5, h6 {" +
                                "font-family: 'Nunito Sans', sans-serif;" +
                                "color: #000000;" +
                                "margin-top: 0;" +
                            "}" +

                            ".logo h1{" +
                                "margin: 0;" +
                            "}" +
                            ".logo h1 a{" +
                                "color: #007591;" +
                                "font-size: 20px;" +
                                "font-weight: 700;" +
                                "font-family: 'Nunito Sans', sans-serif;" +
                            "}" +

                        "</style>" +
                    "</head>" +
                        "<body class='respond' leftmargin='0' topmargin='0' marginwidth='0' marginheight='0'>" +
                        "<!-- header -->" +
                        "<table border='0' width='100%' cellpadding='0' cellspacing='0' bgcolor='ffffff'>" +
                            "<tr>" +
                                "<td align='center' style='background-color: #f1f1f1;'>" +
                                    "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' class='container590'>" +
                                        "<tr>" +
                                            "<td align='center'>" +
                                                "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' style='margin: auto; background: #ffffff;'>" +
                                                    "<tr>" +
                                                        "<td align='center' style='padding: 1em 2.5em;'>" +
                                                            "<table role='presentation' border='0' cellpadding='0' cellspacing='0' width='100%'>" +
                                                                "<tr>" +
                                                                    "<td width='45%' class='logo' style='text-align: left; padding: 20px'>" +
                                                                        "<h1><a href='https://www.asae.com.mx/'>Seguros BECA </a></h1>" +
                                                                      "</td>" +
                                                                      "<td width='55%' class='logo' style='text-align: right;'>" +
                                                                        "<table width='100%' border='0' cellpadding='0' cellspacing='0' style='border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;' class='container590 hide'>" +
                                                                            "<tr>" +
                                                                                "<td  align='center' style='list-style: none; display: inline-block; margin-left: 5px; font-size: 13px; font-weight: 500; '>" +
                                                                                    "<a href='https://www.asae.com.mx/' style='color: #adadad;'>Nosotros  </a>" +
                                                                                "</td>" +
                                                                                "<td  align='center' style='list-style: none; display: inline-block; margin-left: 5px; font-size: 13px; font-weight: 500;'>" +
                                                                                    "<a href='#' style='color: #adadad;'>Experiencia </a>" +
                                                                                "</td>" +
                                                                                "<td  align='center' style='list-style: none; display: inline-block; margin-left: 5px; font-size: 13px; font-weight: 500;'>" +
                                                                                    "<a href='https://www.asae.com.mx/#feature' style='color: #adadad;'>Servicios </a>" +
                                                                                "</td>" +
                                                                                "<td  align='center' style='list-style: none; display: inline-block; margin-left: 5px; font-size: 13px; font-weight: 500;'>" +
                                                                                    "<a href='https://www.asae.com.mx/contacto/atencion-a-clientes' style='color: #adadad;'>Contacto </a>" +
                                                                                "</td>" +
                                                                            "</tr>" +
                                                                        "</table>" +
                                                                      "</td>" +
                                                                "</tr>" +
                                                            "</table>" +
                                                        "</td>" +
                                                    "</tr>" +
                                                    "<tr>" +
                                                        "<td align='center' valign='middle' class='hero bg_white' style=' background: #f1f1f1; position: relative; z-index: 0;'>" +
                                                          "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                "<tr>" +
                                                                    "<td valign='middle' width='50%'>" +
                                                                      "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                        "<tr>" +
                                                                          "<td>" +
                                                                            "<img src='https://www.asae.com.mx/01/BECA/bg_1.jpg' alt='' style='width: 100%; max-width: 600px; height: auto; margin: auto; display: block;'>" +
                                                                          "</td>" +
                                                                        "</tr>" +
                                                                      "</table>" +
                                                                "</td>" +
                                                                "<td valign='middle' width='50%' style='background: #f1f1f1;'>" +
                                                                  "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                    "<tr>" +
                                                                      "<td class='text' style='text-align: left; padding: 20px 30px;'>" +
                                                                            "<h2 style='color: #007591; font-size: 32px; margin-bottom: 0; font-weight: 200; line-height: 1.4; text-align: center;'>Gracias por cotizar con nosotros .</h2>" +
                                                                            "<p style='font-size: 14px; line-height: 2; color: #6b6b6b; text-align: center;'> Enseguida uno de nuestros ejecutivos se comunicará contigo.</p>" +

                                                                      "</td>" +
                                                                    "</tr>" +
                                                                  "</table>" +
                                                                "</td>" +
                                                                "</tr>" +
                                                            "</table>" +
                                                        "</td>" +
                                                    "</tr>" +

                                                    "<tr>" +
                                                        "<td align='center' style=''>" +
                                                            "<table border='0' align='center' width='590' cellpadding='0' cellspacing='0' style='margin: auto; background: #ffffff; padding: 2.5em;'>" +
                                                                "<tr>" +
                                                                    "<td align='center' style='padding: 1em 4em;'>" +
                                                                        "<h2 style='color: #007591; font-size: 28px; margin-top: 0; line-height: 3; font-weight: 400;'>Información enviada.</h2>" +
                                                                        "<p style='font-size: 14px; line-height: 1.8; color: #a5a5a5;'> Te agradecemos que nos hayas contactado.</p>" +
                                                                    "</td>" +
                                                                "</tr>" +
                                                                "<tr>" +
                                                                    "<td>" +
                                                                        "<table role='presentation' border='0' cellpadding='0' cellspacing='0' width='100%'>" +
                                                                            "<tr>" +
                                                                              "<td valign='top' width='100%' style='padding-top: 20px;  padding: 5px 15px; ' class='services'>" +
                                                                                "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                                  "<tr>" +
                                                                                    "<td class='icon' colspan='2' style='margin-top: 0; font-size: 13px; text-align: center;'>" +
                                                                                      "<img src='https://www.asae.com.mx/01/001-diet.png' alt='' style='width: 50px; max-width: 600px; height: auto; margin: auto; display: block;'>" +
                                                                                      "<br>" +
                                                                                    "</td>" +
                                                                                  "</tr>" +
                                                                                  "<tr>" +
                                                                                    "<td style='margin-top: 0; font-size: 13px; text-align: center; background-color: #dcdcdc'>" +
                                                                                        "<p>Nombre </p>" +
                                                                                    "</td>" +
                                                                                     "<td style='margin-top: 0; font-size: 13px; text-align: center; color: #007591; background-color: #d2d2d2'>" +
                                                                                        "<p>" + usuario.nombre + "</p>" +
                                                                                    "</td>" +
                                                                                  "</tr>" +
                                                                                  "<tr>" +
                                                                                    "<td style='margin-top: 0; font-size: 13px; text-align: center; background-color: #dcdcdc'>" +
                                                                                        "<p>Email </p>" +
                                                                                    "</td>" +
                                                                                     "<td style='margin-top: 0; font-size: 13px; text-align: center; color: #9E9E9E; background-color: #f3f3f3'>" +
                                                                                        "<p>" + usuario.email + "</p>" +
                                                                                    "</td>" +
                                                                                  "</tr>" +

                                                                                    "<tr>" +
                                                                                        "<td style='margin-top: 0; font-size: 13px; text-align: center; background-color: #dcdcdc'>" +
                                                                                            "<p>Teléfono</p>" +
                                                                                        "</td>" +
                                                                                        "<td style='margin-top: 0; font-size: 13px; text-align: center; color: #9E9E9E; background-color: #f3f3f3'>" +
                                                                                            "<p>" + usuario.telefono + "</p>" +
                                                                                        "</td>" +
                                                                                    "</tr>" +
                                                                                    "<tr>" +
                                                                                        "<td style='margin-top: 0; font-size: 13px; text-align: center; background-color: #dcdcdc'>" +
                                                                                            "<p>Cotizar </p> " +
                                                                                        "</td>" +
                                                                                        "<td style='margin-top: 0; font-size: 13px; text-align: center; color: #007591; background-color: #d2d2d2'>" +
                                                                                            "<p>" + usuario.cotizar + "</p>" +
                                                                                        "</td>" +

                                                                                    "</tr>" +
                                                                                    "<tr>" +
                                                                                        "<td style='margin-top: 0; font-size: 13px; text-align: center; background-color: #dcdcdc'>" +
                                                                                            "<p>Mensaje </p>" +
                                                                                        "</td>" +
                                                                                        "<td style='margin-top: 0; font-size: 13px; text-align: center; color: #9E9E9E; background-color: #f3f3f3'>" +
                                                                                            "<p>" + usuario.message + "</p>" +
                                                                                        "</td>" +
                                                                                    "</tr>" +
                                                                                "</table>" +
                                                                              "</td" +
                                                                            "</tr>" +
                                                                        "</table>" +
                                                                    "</td>" +
                                                                "<tr>" +
                                                            "</table>" +
                                                        "</td>" +
                                                    "</tr>" +
                                                    "<tr>" +
                                                        "<td  style=' background: #f1f1f1;    padding: 2.5em;'>" +
                                                            "<table role='presentation' border='0' cellpadding='0' cellspacing='0' width='100%'>" +
                                                                "<tr>" +
                                                                    "<td valign='middle' width='50%'>" +
                                                                        "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                            "<tr>" +
                                                                                "<td>" +
                                                                                    "<img src='https://www.asae.com.mx/01/about.jpg' alt='' style='width: 100%; max-width: 600px; height: auto; margin: auto; display: block;'>" +
                                                                                "</td>" +
                                                                            "</tr>" +
                                                                        "</table>" +
                                                                    "</td>" +
                                                                    "<td valign='middle' width='50%'>" +
                                                                        "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                            "<tr>" +
                                                                                "<td class='text-services' style='text-align: left; padding-left:25px;'>" +
                                                                                    "<div class='heading-section'>" +
                                                                                        "<h2 style='color: #007591; font-size: 28px; margin-top: 0; line-height: 1.4; font-weight: 400; text-align: center;'>ACERCA DE NOSOTROS</h2>" +
                                                                                        "<p style='font-size: 14px; line-height: 1.8; color: #a5a5a5;'>Corredor de Seguros y Fianzas consolidado, dedicado a brindar productos y servicios orientados a satisfacer las necesidades de nuestros clientes.</p>" +
                                                                                        "<p><a href='https://www.asae.com.mx/' style='border-radius: 5px;background: #007591; color: #fff; padding: 5px 15px; display: inline-block; font-size: 14px;  padding: 10px 30px;'>Leer más</a></p>" +
                                                                                    "</div>" +
                                                                                "</td>" +
                                                                            "</tr>" +
                                                                        "</table>" +
                                                                    "</td>" +
                                                                "</tr>" +
                                                            "</table>" +
                                                        "</td>" +
                                                    "</tr>" +
                                                    "<tr>" +
                                                        "<td>" +
                                                            "<table role='presentation' border='0' cellpadding='0' cellspacing='0' width='100%'>" +
                                                                "<tr>" +
                                                                    "<td valign='middle' width='33.333%' style='padding: 2.8em 0; background-color: #007591;'>" +
                                                                        "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                            "<tr>" +
                                                                                "<td class='counter-text'>" +
                                                                                    "<span class='num'></span>" +
                                                                                "</td>" +
                                                                            "</tr>" +
                                                                        "</table>" +
                                                                    "</td>" +
                                                                    "<td valign='middle' width='33.333%' style='padding: 2.8em 0; background-color: #0491b3;'>" +
                                                                        "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                            "<tr>" +
                                                                                "<td class='counter-text'>" +
                                                                                    "<span class='num'></span>" +
                                                                                "</td>" +
                                                                            "</tr>" +
                                                                        "</table>" +
                                                                    "</td>" +
                                                                    "<td valign='middle' width='33.333%' style='padding: 2.8em 0; background-color: #00c0ef;'>" +
                                                                        "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%'>" +
                                                                            "<tr>" +
                                                                                "<td class='counter-text'>" +
                                                                                    "<span class='num'></span>" +
                                                                                "</td>" +
                                                                            "</tr>" +
                                                                        "</table>" +
                                                                    "</td>" +
                                                                "</tr>" +
                                                            "</table>" +
                                                        "</td>" +
                                                    "</tr>" +


                                                    "<tr>" +
                                                        "<td style='padding: 2.5em; background: #000000; color: #9E9E9E'>" +
                                                            "<table align='center' role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%' style='margin: auto;'>" +
                                                                    "<tr>" +
                                                                        "<td valign='middle' class='bg_black footer email-section'>" +
                                                                            "<table role='presentation' cellspacing='0' cellpadding='0' border='0' width='100%' style='margin: auto;'>" +
                                                                                "<tr>" +
                                                                                    "<td width='100%' style='text-align: center;'>" +
                                                                                        "<p style='font-size: 22px; margin-top: 0;'>Dirección:San francisco 1626 – 608 Col. Del valle, delegación. Benito Juárez 03104 ciudad de México, México</p>" +
                                                                                    "</td>" +
                                                                                "</tr>" +
                                                                                "<tr>" +
                                                                                    "<td width='100%' style='text-align: center;'>" +
                                                                                        "<p style='margin-top: 0; font-size: 14px; '>¿Quieres recibir más correos electrónicos con nuestras promociones? Usted puede <a href='https://www.asae.com.mx/contacto/atencion-a-clientes' style='font-size: 14px; color: #00afc5;'>contactarnos aquí</a></p>" +
                                                                                    "</td>" +
                                                                                "</tr>" +
                                                                                "<tr>" +
                                                                                    "<td width='100%' style='text-align: center;'>" +
                                                                                        "<table>" +
                                                                                            "<tr>" +
                                                                                                "<td>" +
                                                                                                    "<img src='https://www.asae.com.mx/01/004-twitter-logo.png' alt='' style='width: 24px; max-width: 600px; height: auto; display: block;'>" +
                                                                                                "</td>" +
                                                                                                "<td>" +
                                                                                                    "<img src='https://www.asae.com.mx/01/005-facebook.png' alt='' style='width: 24px; max-width: 600px; height: auto; display: block;'>" +
                                                                                                "</td>" +
                                                                                                "<td>" +
                                                                                                    "<img src='https://www.asae.com.mx/01/006-instagram-logo.png' alt='' style='width: 24px; max-width: 600px; height: auto; display: block;'>" +
                                                                                                "</td>" +
                                                                                            "</tr>" +
                                                                                        "</table>" +

                                                                                    "</td>" +
                                                                                "</tr>" +
                                                                        "</table>" +
                                                                        "</td>" +
                                                                    "</tr>" +
                                                                  "</table>" +
                                                        "</td>" +
                                                    "</tr>" +
                                                "</table>" +
                                            "</td>" +
                                        "</tr>" +
                                        "<tr>" +
                                            "<td height='25' style='font-size: 25px; line-height: 25px;'>&nbsp;</td>" +
                                        "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                        "</table>" +
                        "<!-- end header -->" +
                        "</body>" +
                    "</html>" +

					   "";
			return body;
		}
	}
}
