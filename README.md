# BasicProgramming

### En esta practica, se evaluan conocimientos basicos de C#.
### Para ello, cree un proyecto C# de consola y realice lo que se pide.
## 1. Conceptos generales.
### 1.1.Cree un metodo llamado GreetCountries, que reciba como parametros dos cadenas de texto: inputFile, y outputFile, donde inputFile sera la ruta al archivo entrada countries.txt (anexo a esta practica) y outputFile sera un nuevo archivo de salida con el resultado de las siguientes indicaciones.
### 1.2.El archivo countries.txt, contiene enlistado nombres de diferentes paises. Su tarea sera copiar las mismas lineas de texto en el archivo de salida pero con el formato: ‘Saludos hasta XXXX!’; donde XXXX es el pais con respecto al número de linea.

### 1.3.El nombre del archivo de salida se debe asignar desde codigo, antes de la llamada al metodo, y ademas, el nombre debe contener la fecha actual en formato: “Year-MonthName-Day”: Ejemplo: Countries 2008-Apr-08.
### 1.4.En el metodo Main de Program.cs, ejecute el metodo GreeCountries.
## 2. Programacion orientada a objetos
### 2.1.Crea una clase abstracta con dos atributos y dos metodos.
### 2.2.Crea una clase (hija) que herede de la clase anterior (padre) y asigna los modificadores de acceso adecuados para lo siguientes:
 #### • Los atributos y metodos de la clase padre no pueden ser accedidos por otras clases mas que por sus clases derivadas.
 #### • Ambas clases solo pueden ser accedidas por clases del mismo namespace.
 #### • Los atributos de la clase derivada no pueden ser accedidos mas que por la clase actual.
 #### • Los metodos de la clase dervida pueden ser accedidos por cualquier clase.
 #### • La clase derivada debera contener el modificador adecuado para no permitir nuevas derivaciones de esta.
### 2.3.Agregue un constructor a la clase derivada que reciba valores por parametro para sus atributos.
### 2.4.En el metodo Main de Program.cs, instancie un objeto de la clase derivada y ejecute sus 2
metodos.
## 3. Manejo de excepciones.
### 3.1.Cree una clase con un metodo llamado Fail que arroje una excepcion con mensaje “Error!”.
### 3.2.En el metodo Main de Program.cs, ejecute el metodo Fail y atrape el error para imprimir el mensaje de la excpecion en consola.
### 3.3.Aplique manejo de errores sobre el metodo GreetCountries, de tal forma que prevenga las excpeciones FileNotFoundException asi como una excepcion general (Exception).

## Criterios de evaluacion:
  • Se cumple con las indicaciones de la practica.
  • El codigo sigue la convencion de nomenclatura C#.
  • Para el manejo de ficheros, utilizar StreamReader.
  • La abstraccion utilizada para el ejercicio 2 (OOP) es coherente.
## Anexos
Countries.txt:
https://gist.githubusercontent.com/kalinchernev/486393efcca01623b18d/raw/daa24c9fea66afb7d68f8
d69f0c4b8eeb9406e83/countries
