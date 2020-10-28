## DoubleA.DataAccess.Contract

This library provides simple interfaces to help with accessing data from a relational database using an ORM like EntityFramework.

### Repository
- #### IRepository
  Represents a basic data repository meant to be used as the common interface for all repository implementatins.
- #### IKeyedEntityRepository
  Inherits from **_IRepository_** and represents a simple repository for **_IKeyedEntity_**.
  
### Unit of Work
- #### IUnitOfWork
  Represents a basic unit-of-work manager that manages multiple repositories.
