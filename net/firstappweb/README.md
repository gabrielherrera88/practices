-Objetivo:
Tener una base de solucion para una web app con una arquitectura basica, no es una guia para aplicacion empresarial pero si para fortalecer conceptos e ideas.



-Stack y Herramientas:
Visual Studio 2017
Full Framework 4.8
C#
MVC
WebApi - RESTful Services
Web Services
WCF
HTML5
CSS3
JavaScript
AJAX
jQuery
Bootstrap
Font Awesome



-Conceptos:
Patron de Vistas y Controladores con/sin Modelos.
Consumo/peticiones a Controladores de MVC y WebApi.
Desarrollo y consumo de servicios de tipo Web Service y WCF.
Acceso a datos.
Creacion de vistas enriquecidas.



-MVC y WebApi:
Que son?
MVC es un patron de arquitectura para separar las vista, los datos y la logica de negocio.
WebApi es un framework para la creacion de Servicios RESTful (modelo arquitectonico web basado en el protocolo HTTP, protocolo sin estado).

Para que sirven?
MVC provee un mecanisco para generar y renderizar vistas por medio de un motor llamado Razor, dichas vistas se pueden armar con HTML puro o con helpers de Razor.
Los controladores exponen metodos que, dependiendo del fin, retornan vistas o solamente datos, en el caso de las vistas es posible inyectarles un modelo (El modelo es un concepto
que se refiere a los datos asociados a la vista, basicamente). Por lo cual con MVC vamos a poder devolver vistas con/sin datos o devolver solo datos.
WebApi provee una pila de helpers y clases para generar y exponer servicios REST, dichos servicios eventualmente van a ser consumidos por un cliente (llamese cliente a una app
satelite, una vista, un cliente mobile).

Cuando uno y cuando el otro?
Si tu cliente va a ser una app mobile, una app satelite, tu misma app, claramente el mejor enfoque es utilizar WebApi y exponer servicios, dentro de tu app dichos servicios los
podes consumir, por ejemplo, directamente desde tu vista con javascript mediante AJAX.
Si la app que estas desarrollando no va a ser consumida por terceros, o no posees tantos conocimientos de front, tu mejor enfoque seria utilizar MVC, te va a permitir armar vistas
rapidamente con Razor y consumir metodos de controladores que eventualmente retornen modelos con datos (eventualmente obtenidos de otro servicio externo, de una base de datos, etc).
Ambas tecnologias pueden vivir en el mismo proyecto :).



-Back End:
Nuestro backend esta conformado por un popurri de tecnicas y herramientas para poder tener el conocimiento de como se desarrollan, su potencial y en que caso utilizarlos.
Veremos como exponer servicio mediante Web Service, WCF y RESTful.

Que son?
Un Web Service es una capa que es accesible a traves de protocolos web, uno de ellos SOAP, que usa XML como estandar para la transferencia de datos. En este caso se utilizara para
que nuestro frontend consuma datos, tambien se podria desplegar en una red especifica con ciertas configuraciones para que sea accesible desde internet, bajo este punto aplica
exactamente para los servicios WCF y RESTful.
WCF es la evolucion de Web Service y es un conjunto de librerias y conceptos propio de Microsoft para construir aplicaciones orientadas a servicio (Arquitectura SOA), a su vez
es una tecnologia que aglomera otras como Web Service, .Net Remoting, MSMQ y Enterprise Services.

Para que sirven?
Basicamente para intercomunicar sistemas y aplicaciones. Tambien mediante arquitecturas orientadas a servicios y aplicaciones distribuidas es mucho mas facil escalarlas y eventualmente
dependiendo del trafico balancearlas, entre otras cosas.

Cuando uno y cuando el otro?
Esto dependera del contexto de la aplicacion y la experiencia del desarrollador o arquitecto para definir y/o predecir, en base a los requerimientos, el futuro del sistema.
Pero si sabemos de ante mano que nuestra aplicacion sera core o tendra alguna funcionalidad compartida con otra aplicacion, sera un buen momento para seleccionar cualquiera de las
3 tecnicas, pudiendo mezclarlas o hacerlas convivir, de esta manera nuestra aplicacion podra exponer servicios y que otras aplicaciones se alimenten o consuman dichos servicios,
entre otras cosas.



-Desarrollo terminado:
Y ahora que?
Una vez finalizado nuestro desarrollo (y testeado en nuestro entorno de desarrollo: IDE Visual Studio + IIS Express) es hora de desplegarlo y verlo en funcionamiento, aca entra
en juego nuestro gran amigo IIS (Internet Information Services), un servidor con un sin fin de caracteristicas que nos permitira desplegar nuestros diferentes artefactos (ya que
nuestra aplicacion es una pero esta compuesta por varias patas), determinar, entre otras cosas, con que usuario de servicio se ejecutara, por que puerto escucharan nuestros artefactos,
configurar logs, administrar permisos, etc.