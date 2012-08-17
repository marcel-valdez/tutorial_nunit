Tutorial de NUnit
==============

1.1  ¿Qué es NUnit?
NUnit es un framework para pruebas unitarias en los lenguajes .Net. Inicialmente fue porteado de JUnit; el último lanzamiento de NUnit es la versión 2.6 al día 17 de Agosto del 2012, y es el séptimo lanzamiento de esta herramienta basada en xUnit para Microsoft .NET. Está escrito completamente en C# y ha sido completamente rediseñado para aprovechar muchas de las nuevas features de lenguaje .Net, por ejemplo: atributos personalizados y otras capacidades de reflexión.	

1.2	¿Qué es una prueba de software?
De acuerdo a (Wikipedia, 2012), una prueba es una investigación conducida para proveer a los interesados (en este caso el equipo de desarrollo) con información sobre la calidad del producto o servicio bajo prueba. Entre las técnicas de pruebas, se incluye el proceso de ejecutar un programa o aplicación con objetivo de encontrar errores o defectos de software.

1.3	¿Qué es una prueba unitaria?
Se refiere a las pruebas que verifican la funcionalidad de una sección específica de código, usualmente al nivel de función. En un ambiente orientado a objetos, esto es usualmente al nivel de clase, y las pruebas unitarias mínimas incluyen los constructores y destructores de objetos. Cabe hacer notar que una prueba unitaria, para ser efectiva, debe hacerse de manera aislada, esto implica que no debe de depender ni verse afectado por ninguna otra pieza de código más que la que se encuentra bajo prueba.
	
	En el contexto de pruebas unitarias escritas por un programador con una herramienta como NUnit, una prueba unitaria es una pieza código que ejercita una pequeña, específica área de funcionalidad del código siendo probado. Usualmente una prueba unitaria ejercita un método particular en un contexto particular. Por ejemplo, tal vez se agregue un valor grande al final de una lista, o se borre un patrón de caracteres de un string y luego confirmar que estos hayan sido borrados. (Hunt & thomas, 2003)
	
	Las pruebas unitarias se realizan para probar que una pieza de código hace lo que un programador cree que debería hacer. De otra manera, cualquier resultado correcto sería coincidencia,  esto se le llama: “programación por coincidencia” (Hunt & Thomas, 1999).

1.4	¿Qué es una prueba de integración?
Es cualquier tipo de prueba de software que busca verificar las interfaces entre componentes, contra el diseño de software. Los componentes de software pueden ser integrados de una manera iterativa o todos juntos. El objetivo de las pruebas de integración es el de encontrar defectos en la interacción, por medio de sus interfaces, de los componentes o módulos integrados.

1.3. ¿Por qué hacer pruebas? 
Razones para hacer pruebas:
- En un estudio conducido por la NIST en el 2002, encontró que los defectos de software cuestan $59.5 billones de dólares a los estados unidos de América. Más del 33% de este costo se pudo haber evitado y se hubieran hecho mejores pruebas de software
- Se sabe que conforme más temprano se encuentre un error, más barato es arreglarlo. Como se puede observar en la tabla a continuación, un defecto que se presente en la construcción de software, que es encontrado después del lanzamiento del software, puede costar %2500 de lo que hubiera costado arreglarlo en construcción.
1 Costo de arreglas un defecto, acorde al momento que se presenta.
 
1.4. ¿Por qué hacer pruebas automatizadas?
En (Matyas, Glover, & Duvall, 2007) nos explican algunas razones:
-	Debido al corto tiempo entre la codificación y ejecución de pruebas sobre el código resultante, las pruebas unitarias son una forma eficiente de debugging
-	Si vamos a construir sistemas que son verdaderamente confiables, tenemos que asegurar esa confiabilidad al nivel de objeto, lo que únicamente se puede lograr con pruebas unitarias [automatizadas]. Las pruebas deben efectivamente ejercitar el uso del objeto; y también, las pruebas deben ejecutarse frecuentemente (con cada cambio al código).
-	Debido a que los objetos en un sistema de software deben comunicarse entre sí, las pruebas deben poder ejecutarse en cualquier momento y cada vez que cambia algo en el sistema. Esto sólo se puede lograr si las pruebas se ejecutan automáticamente.
