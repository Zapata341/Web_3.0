using System; 

class Pila{

    // Variables de referencia 

    private Nodo cabecera; 
    private Nodo referencia; 

    public Pila(){
        // Inicializando la cabecera 
        cabecera = new Nodo();
        // La pila esta vacia entonces su primer valor sera null 
        cabecera.Siguiente = null;  
    }

    // Apilar 

    public void Push(string pDato){
        // Crear nodo temporal 
        Nodo tmp = new Nodo(); 
        tmp.Dato = pDato; 
        // Conectar a la lista 
        tmp.Siguiente = cabecera.Siguiente;
        // Conectar la cabecera al temporal 
        cabecera.Siguiente = tmp;  

    } 

    // Desapilar 

    public string Pop(){
        // Variable de apoyo 
        string valor = ""; 
        // Validar 
        if(cabecera.Siguiente != null){ 
            referencia = cabecera.Siguiente; 
            valor = referencia.Dato; 
            // Sacarlo de la pila 
            cabecera.Siguiente = referencia.Siguiente; 
            referencia.Siguiente = null; 
        }

        return valor; 
    } 

    // Obtener el elemento en la cima de la pila 
     public string Peek(){
         string valor = ""; 
        // Validacion 
         if(cabecera.Siguiente != null){
            referencia = cabecera.Siguiente; 
            valor = referencia.Dato;  
         }

         return valor; 
     }

     // Puntero 

     public void Apuntador(){
        referencia = cabecera; 
        while(referencia.Siguiente != null){
            // Avanzar todos los elementos de la pila 
            referencia = referencia.Siguiente; 
            string dato = referencia.Dato; 
            Console.WriteLine("{0}",dato); 
        }
     }

}
