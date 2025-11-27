<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

# Diseñando figuras con principios de POO

Vas a tener que diseñar las siguientes clases a continuación teniendo en cuenta
las guías de diseño vistas durante el curso. Las clases representan figuras
geométricas que serán usadas en el futuro en un programa de dibujo. Por ahora
deberás implementar las responsabilidades y relaciones que corresponda.

La clase `Square` representa un cuadrado y tiene las siguientes responsabilidades:

* Conocer el largo de los lados con `Side`.
* Calcular el perímetro con `Perimeter`; el perímetro se calcula como `Side *
  4`.
* Calcular el área con `Area`; el área se calcula como `Side * Side`.

La clase `Circle` representa un círculo y tiene las siguientes responsabilidades:

* Conocer el radio con `Radius`.

* Calcular el perímetro con Perimeter; el perímetro se calcula como `2 * Math.PI
  * Radius`.

* Calcular el área con Area; el área se calcula como `Math.PI * Radius * Radius`.

La clase `Triangle` representa un triángulo y tiene las siguientes responsabilidades:

* Conocer la longitud de sus tres lados con `Side1`, `Side2` y `Side3`.

* Calcular el perímetro con `Perimeter`; el perímetro se calcula como `Side1` + `Side2` + `Side3`.

* Calcular el área con `Area`; el área se calcula usando la fórmula de Herón:

    * Primero se calcula el semiperímetro: `s = (Side1 + Side2 + Side3) / 2`.

    * Luego el área: `Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3))`.

Además, todas las figuras deben tener un identificador único, que será utilizado
para exportar e importar las figuras.

Las figuras puede ser exportadas a formato [JSON](https://www.json.org/). A
continuación aparecen ejemplos de representaciones en formato JSON de las
diversas figuras:

```json
{
  "type": "square",
  "id": 12,
  "side": 5.2
}
```

```json
{
  "type": "circle",
  "id": 31,
  "radius": 4.9
}
```

```json
{
  "type": "triangle",
  "id": 46,
  "side1": 5.8,
  "side2": 6.0,
  "side3": 7.1
}
```

Puedes obtener la representación JSON de cualquier objeto con [`string JsonSerializer.Serialize()`](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer.serialize?view=net-10.0).

Ten en cuenta que el programa:

1. Tendrá nuevos tipos de figuras en el futuro.

2. Podrá exportar a otros formatos además de JSON más adelante.

3. Habrá otros elementos que no son figuras pero que también pueden ser
   exportados junto con las figuras.

> [!NOTE]
> Para que la exportación con `JsonSerializer` funcione puede ser necesario usar
> el atributo
> [`JsonDerivedType`](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.metadata.jsonderivedtype?view=net-10.0)
> pero **no deberás hacerlo** en este ejercicio.

## Parte 1

**En papel**, ya sea mediante un diagrama de clases UML o con código C#, diseña
una clase de figura —la que quieras— y luego el resto de la consigna para
esa clase.

## Parte 2

**En código**, diseña el resto de las clases. En el programa principal, deberás
crear instancias de las figuras e imprimir en pantalla el resultado de exportar
a JSON.
