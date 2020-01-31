# GraphQL on ASP .NET

> `GraphQL` is a query langauge for APIs and a runtime for your data. 

We will make an API that fetches div's properties and their children's divs.  
<div id="picture">

`code behind` 

`grapql`

To install: 

To set up an ASP.NET(2.1.801) API for GraphQL

`dotnet new web api`


Model: the application
View: What the consumer sees, often HTML, XML, or JSON.
Controller: A thin layer connecting Model & View

Similar to [Polaris API](https://polaris.shopify.com/resources/graphql-api) at Shopify

Our Schema will have 

```graphql
query pages {
    id
    title 
    description
    category {
        name
        id
    order
    keywords
       
    }
}
```
