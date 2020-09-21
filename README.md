# Web Application MVC

Aula 02: https://www.youtube.com/watch?v=6ufCFrAXUuQ&list=PLzKclr7RPbI1x48XgRBBbgAlM8eGaf5Qn

## Pastas:
* App_Data: Carrega dados do banco de dados
* App_Start: 
   * RouteConfig: Carrega as rotas(organizar)
   * BundleConfig: Arquivo que gerencia os scripts(organizar, para que nao tenha muitas requisições)
   * FilterConfig: Arquivo de Filtros, mensagens de erro e alertas (não é obrigatório, apenas uma organização)
   
* A função no `Controller` chamada `ActionResult` sempre vai retornar uma View();

* `@Html.ActionLink("", "", "")` Nome do Link, Função e Nome do Controller.

* `@RenderBody()` - Fica no \_Layout e serve para mostrar aonde o conteudo será rederizado.
* `@{ Layout = "~/Views/Shared/_Layout.cshtml"; }` - Serve para carregar o conteudo do Layout. Se não por entre { } não tem como dar "espaços"
* Arquivo: `_ViewStart.cshtml` - Faz com que todas View iniciem com esses codigos que estiverem ali.


