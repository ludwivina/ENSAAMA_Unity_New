# ENSAAMA_Unity_New

## Vie et Mort
Pour détruire un component OU un gameObject
```csharp
Destroy(gameObejct);
//avec un délai de 3 secondes :
Destory gameObject, 3f;
```

Pour créer un gameObject à partir d'une source :
- existant dans la scène :
```csharp
Instantiate gameObejct;
```