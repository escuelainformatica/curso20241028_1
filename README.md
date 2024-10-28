# ciclos y linq

## sumar

```c#
var total=listado.Sum(alias => alias.columna); // sumar todas las columnas de listado
var total=listado.Avg(alias => alias.columna); // promedio
var total=listado.Min(alias => alias.columna); // mínimo
var total=listado.Max(alias => alias.columna); // máximo
```



## foreach

Se realiza una operacion por cada fila (no devuelve valor)

```c#
listado.ForEach(alias => Console.WriteLine(alias));
```

## OrderBy  / OrderByDesc

Se ordena una columna. Nota: Es importante el orden que se aplica el ordenamiento

```c#
var listadoOrdenado=listado.orderBy(alias => alias.columna).ToList(); // se ordena por la columna ascendentemente
```

## Where

Para filtrar valores se puede usar Where()

```c#
var listadoFiltrado=listado.Where( alias => alias.columna == condicion).ToList(); // filtrar por la col.
```

