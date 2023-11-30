# Gestion des Employés ASP.NET Core

## Introduction

Ce projet est une application web ASP.NET Core de gestion des employés. Il permet de gérer les employés avec des opérations CRUD de base.

## Instructions pour Visual Studio 2022

1. Ouvrez Visual Studio 2022 et créez un nouveau projet ASP.NET Core.
2. Choisissez le modèle MVC.
3. Structure de l'application : dossiers distincts pour les fichiers statiques, contrôleurs, modèles, etc.

## Modèle Employee

Ajoutez la classe Employee au dossier Models.

## Interface Repository
Dans le dossier Models/Repositories, créez une interface IRepository.
Implémentez l'interface avec la classe EmployeeRepository utilisant LINQ.
Contrôleur EmployeeController
Dans le dossier Controllers, créez un contrôleur EmployeeController avec des actions CRUD.

 ## Injection de Dépendances
Inscrivez les services dans Program.cs. Injectez IRepository dans EmployeeController.

### Vues
Créez des vues pour les actions : Index, Create, Edit, Delete, Details.
Ajoutez une barre de navigation avec des liens vers ces vues.
Recherche et Statistiques
Ajoutez une fonction de recherche avec une barre de recherche.
Obtenez des statistiques telles que le nombre d'employés, le salaire moyen, etc.
### Thème Bootstrap
Choisissez un thème Bootstrap sur bootswatch.com.
Téléchargez le fichier CSS et ajoutez-le au dossier wwwroot/css.
Modifiez le fichier _Layout.cshtml pour utiliser le nouveau thème.
