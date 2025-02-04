﻿namespace SalesWebMvc.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc

type HomeController () =
    inherit Controller()

    member this.Index () =
        this.View()

    member this.About () =
        this.ViewData.["Message"] <- "Pagina de teste de um sistema ASP.NET Core MVC"
        this.View()

    member this.Contact () =
        this.ViewData.["Message"] <- "Your contact page."
        this.View()

    member this.Error () =
        this.View();
