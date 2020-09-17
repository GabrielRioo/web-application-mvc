# Web Application MVC

## Pastas:
* App_Data: Carrega dados do banco de dados
* App_Start: 
   * RouteConfig: Carrega as rotas(organizar)
   * BundleConfig: Arquivo que gerencia os scripts(organizar, para que nao tenha muitas requisições)
   * FilterConfig: Arquivo de Filtros, mensagens de erro e alertas (não é obrigatório, apenas uma organização)
   
* A função no `Controller` chamada `ActionResult` sempre vai retornar uma View();

* `@Html.ActionLink("", "", "")` Nome do Link, Função e Nome do Controller.


