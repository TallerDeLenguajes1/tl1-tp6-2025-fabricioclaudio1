[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

**¿String es una tipo por valor o un tipo por referencia?**

String es un tipo por referencia.

Una cadena es un objeto de tipo String cuyo valor es texto. Internamente, el texto se almacena como una colección secuencial de solo lectura de objetos Char. La propiedad Length de una cadena representa el número de objetos Char que contiene, no el número de caracteres Unicode. Para obtener acceso a los puntos de código Unicode individuales de una cadena, use el objeto StringInfo.

**¿Qué secuencias de escape tiene el tipo string?**

Secuencia de escape		Nombre de carácter							Codificación Unicode
\'						Comilla simple								0x0027
\"						Comilla doble								0x0022
\\						Barra invertida								0x005C
\0						Nulo										0x0000
\a						Alerta										0x0007
\b						Retroceso									0x0008
\e						Escapar										0x001B
\f						Avance de página							0x000C
\n						Nueva línea									0x000A
\r						Retorno de carro							0x000D
\t						Tabulación horizontal						0x0009
\v						Tabulación vertical							0x000B
\u						Secuencia de escape Unicode (UTF-16)		\uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç")
\U						Secuencia de escape Unicode (UTF-32)		\U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = "👽")
\x						Secuencia de escape Unicode similar a       \xH[H][H][H] (intervalo: 0 - FFFF; ejemplo: \x00E7 or \x0E7 or \xE7 = "ç")
                        "\u"  excepto con longitud variable	

**¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?**

C# también permite la interpolación de cadenas textuales, por ejemplo, en varias líneas, mediante la sintaxis $@ o @$.

Para interpretar las secuencias de escape literalmente, use un literal de cadena textual. Las cadenas textuales interpoladas comienzan por el carácter $, seguido del carácter @. Los tokens $ y @ se pueden usar en cualquier orden; tanto $@"..." como @$"..." son cadenas textuales interpoladas válidas.