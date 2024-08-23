# importamos la libreria para ejecutar el error en caso de que se de 
import logging 
import os
# iniciamos la configuracion basica del log de exepciones

logging.basicConfig(
    # este es el nombre que tendra nuestro archivo logging
    filename='user_input.log',
    # este es el nivel de log que se captura o registra
    level=logging.ERROR,
    # este es el formato que tendra nuestro log de eventos
    format='%(asctime)s - %(levelname)s - %(message)s',
    # este es el formato que deberia tener nuestra hora que se muestra en  
    datefmt= '%d- %m - %Y %H:%M:%S'                            
)
# aqui es donde recien trabajaremos nuestro programa
def solicitar_numero():
    # aqui solicitamos un numero al usuario
    while True:
      try:
         # aqui solicitamos un numero al usuario
         numero = int(input("ingrese un numero: "))
         return numero
      except ValueError as e:
         # aqui capturamos el error y lo registramos en el log de errores
         logging.error("ya cabron ingrese bien")
         print("ingrese un numero")
# aqui termina mi primera def, si se ingresa algo que no sea un numero arroja que no se ingreso un dato valido

# recien comienzo a escribir la logica de las operaciones
def operadores(operador, a, b):
   try:
      # le pedimos el primer operador
      if operador == "+":
        result = a+b
      elif operador == '-':
         result = a - b
      elif operador == '*':
         result = a * b
      elif operador == '/':
         result = a / b
      else:
         raise ValueError("Ingresaste un operador no valido")
      print (f"El resultado de la operacion es:  {result}")
      logging.info("Operacion exitosa: %s %s %s", result)
      return result
   except ZeroDivisionError:
      logging.error("no se puede dividir %s entre %s", a , b)
      print("no se puede dividir entre cero")
   except Exception as e:
      logging.error("Error en la operacion: %s", e)
      print ("Se ha producido un error")



def calculadora():
   while True:
      a=solicitar_numero()
      b=solicitar_numero()

      operador= input("ingrese el operador(+, -, *, /)")
     #aqui le pido al usuario que ingrese su operador
      operadores(operador, a, b)
      
      continuar= input("Desea continunar? (si/no)")
      if continuar !='si':
         break
      os.system("cls")

      
# llamamos a nuestra funcion
calculadora()

# el log de errores me ayuda a identificar los errores de mi programa, con el fin de controlar el flujo de accion de mi programa
    