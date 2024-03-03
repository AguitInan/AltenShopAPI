# AltenShopAPI

Ce back-end, développé en C# avec .NET Core, permet la gestion de produits. Il utilise SQL Server comme système de gestion de base de données.

## Démarrage rapide

### Configuration du serveur et de la base de données SQL Server

1. Ouvrez l'invite de commandes Windows ou PowerShell.
2. Exécutez les commandes suivantes pour créer et démarrer votre instance SQL Server LocalDB :
    ```bash
    sqllocaldb create alten
    sqllocaldb start alten
    ```

### Installation

Assurez-vous d'avoir Visual Studio 2022 installé sur votre machine pour poursuivre.

### Clonage du projet

Clonez le projet dans votre espace de travail local avec :

```bash
git clone https://github.com/AguitInan/AltenShopAPI.git
```

Naviguez ensuite dans le dossier AltenShopAPI et ouvrez AltenShopAPI.sln avec Visual Studio 2022.
La chaîne de connexion se trouve dans le fichier appsettings.json qui se situe dans le dossier ProductAPI.

### Migration de la base de données

Dans le terminal intégré de Visual Studio (Ctrl+ù), naviguez vers le dossier ProductAPI et exécutez :

```bash
dotnet ef migrations add NewMigration # Optionnel
dotnet ef database update
```

### Lancement de l'API

Lancez l'API en sélectionnant le profil ProductAPI dans launchSettings.json. Visitez ensuite https://localhost:7181/swagger/index.html pour tester l'API via Swagger.

### Test avec le Front Angular

Installer Node.js.

L'archive shop-back-products(API-Version).rar contient une version adaptée à cette API.
Dézipper l'archive shop-back-products(API-Version).rar.

Se rendre dans le dossier front, puis ouvrir l'invite de commandes Windows ou PowerShell et effectuer les commandes suivantes :

```bash
npm install
ng serve
```

Après avoir lancé l'API, se rendre à l'adresse suivante pour utiliser l'application front Angular : http://localhost:4200
