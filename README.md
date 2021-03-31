# Prerequisitos para poder compilar el proyecto.
+ [Visual Studio 2019 16.8 o posterior](https://visualstudio.microsoft.com/es/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) con ASP.NET y la carga de trabajo de desarrollo web.
+ [.NET 5.0 SDK or later](https://dotnet.microsoft.com/download/dotnet/5.0)
+ En caso que quieras trabajar con el [Visual Studio Code](https://code.visualstudio.com/download) tienes que tener [dotnet](https://dotnet.microsoft.com/download) para poder ejecutar los comandos desde la terminal

## Para poder ejecutar el proyecto tenemos varias opciones.

+ solo basta con abrirlo en el visual studio.
+ Puedes agregarlo al visual studio code y usar el run la 4 opcion del menu izquierdo quetiene un icono como de play y un escarabajo. 
Arriba solo seleccionan .NET Core Launch (web) (api) algo asi aparece y le dan al boton verde ala izquierda.
+ Desde la power shell o una terminal en linux simplemente escribes dotnet run.

#### En todo caso recomiendo ejecutar el proyecto desde la power Shell o la CMD o desde cualquier terminal Linux con el comando  ```dotnet run``` teniendo previamente instalado [dotnet](https://dotnet.microsoft.com/download) Para no tener ningún inconveniente.
## Para poder probar el crud en general ya que se iso en formato de api rest se puede utilizar la erramienta Postman o la de tu preferencia.

## Las credenciales son

**Superisor:**
+ **User:** supervisor@gmail.com
+ **Password:** SUPERisor1.

**Agente:**
+ **User:** agente@gmail.com
+ **Password:** Agente1.

## Informacion adicional
La prueba realizada no va al 100 porciento se trato de hacer lo mas hacercado a lo solicitado.

## Respuesta de preguntas solicitadas
**1.  ¿Qué recomienda para hacer una aplicación web segura?.**

Desde mi punto de vista: Tener un buien equipo de trabajo, manejar control de versiones para evitarlamayor cantidad debut posibles o un mejor flujo de trabajo, Usar un buen frameworf o patronde diseño.

**2. Indique al menos tres buenas prácticas que beneficien el rendimiento de una aplicación
.Net Core.**
- Manejarla autenticación de usurios  basada en Tokens.
- Manejar las entidades en singular y con sunombre completo.
- Tener un buen uso del tipeo de datos.

**3. Explique de forma breve y concisa, ¿cómo funciona el asincronismo en .Net Core?**

Cuando programamos el código se va ejecutando en el orden en el que fue escrito línea por línea no ejecuta todo el código al mismo tiempo, si no que va siguiendo las instrucciones y hasta terminar una instrucción ejecuta la siguiente línea de código.  
