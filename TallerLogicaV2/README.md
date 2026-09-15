# Taller #3 de POO — Lógica aplicada (estructura corregida)

Solución con 3 proyectos separados, según lo pedido por el profesor:

```
Shared/        -> Class Library con ConsoleHelper (entrada por consola reutilizable)
Ejercicio30/   -> Console App (Operaciones en una Matriz), referencia Shared
Ejercicio35/   -> Console App (Descomposición en Factores), referencia Shared
```

## Shared/ConsoleHelper.cs
M�todo estático `ReadInt(prompt)` que hace el Console.Write + ReadLine +
Parse una sola vez, para no repetirlo en cada ejercicio.

## Ejercicio30/
- `SquareMatrix.cs` — misma lógica de antes.
- `Program.cs` — usa `ConsoleHelper.ReadInt` de Shared.

## Ejercicio35/
- `NumberFactorization.cs` — misma lógica de antes.
- `Program.cs` — usa `ConsoleHelper.ReadInt` de Shared.

## Verificación
Se volvió a comprobar la lógica de los 4 casos de prueba del enunciado
(orden 5 y 10 para la matriz; 72 y 117 para la factorización) — todos
coinciden exactamente.

## Nota
Esta estructura es nuestra mejor interpretación de "carpetas separadas"
+ "proyecto Shared" según el comentario del profesor. Si tienes acceso
al "tutorial 72" que mencionó, compáralo contra esto por si su
ConsoleHelper espera una firma o nombre distinto.
