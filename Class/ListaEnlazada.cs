using System; 
class ListaEnlazada{
    private Nodo cabecera; 
    private Nodo referencia; 

    private Nodo referencia2; 

    private Nodo referenciaBuscar; 


    public ListaEnlazada(){
        cabecera = new Nodo(); 
        cabecera.Siguiente = null; 
    }

    public void Apuntador(){
        // Referencia al inicio 
        referencia = cabecera;

        // Recorrer hasta encontrar el final (todos los elementos)

        while(referencia.Siguiente != null ){
            // avanzamos a referencia (tmp, aux)
            referencia = referencia.Siguiente; 
            // Obtener el dato 
            string d = referencia.Dato; 
             Console.Write("{0} ", d); 
        }
        Console.WriteLine(); 
    } 

      public void Adicionar(string pDato){
        // Referencia al inicio 
        referencia = cabecera; 
        // Recorrer hasta llegar al final 
        while(referencia.Siguiente != null){
            // Avanzar en la referencia 
            referencia = referencia.Siguiente;

        }
        // Crear un nuevo nodo 
        Nodo tmp = new Nodo();
        // Insertar el dato 
        tmp.Dato = pDato;
        // Enlazar todo lo que tenemos
        referencia.Siguiente = tmp; 
    }

    public bool EstaVacia(){
        if(cabecera.Siguiente == null){
            return true;
        } else {
            return false;
        }
    }

    // Buscar el juego y su descripcion ------------------------------------------------------------------------------------

     public Nodo BuscarNodo(string pDato){
        if(EstaVacia() == true){
            return null;
        } 

        referencia2 = cabecera;
        while(referencia2.Siguiente != null){
            referencia2 = referencia2.Siguiente;
            // si lo encuentro lo devuelvo 
            if (referencia2.Dato == pDato){
                return referencia2;
            }
        }
        return null;
    }

    public string BuscarString(string pDato){
        if(EstaVacia() == true){
            return "No se encontro el juego";
        } 

        referencia2 = cabecera;
        while(referencia2.Siguiente != null){
            referencia2 = referencia2.Siguiente;
            // si lo encuentro lo devuelvo 
            if (referencia2.Dato == pDato){
                return referencia2.Dato;
            }
        }
        return "No se encontro el juego";
    }

    public string BuscarDatoAnterior(string pDato){
        referenciaBuscar = cabecera;

        while(referenciaBuscar.Siguiente != null && referenciaBuscar.Siguiente.Dato != pDato){
                referenciaBuscar = referenciaBuscar.Siguiente;
        }

        return referenciaBuscar.Dato;

    }


    // Borrar -------------------------------------------------------------------------------------------------------------

    public Nodo BuscarAnterior(string pDato){
        referenciaBuscar = cabecera;

        while(referenciaBuscar.Siguiente != null && referenciaBuscar.Siguiente.Dato != pDato){
                referenciaBuscar = referenciaBuscar.Siguiente;
        }

        return referenciaBuscar;

    }


     public void borrar(string pDato){
        // Verificar si hay datos 
        if(EstaVacia() == true){
            return;
        }
        // Buscamos los nodos con los que vamos a trabajar 
        Nodo nodoAnterior = BuscarAnterior(pDato);
        Nodo nodoEncontrado = BuscarNodo(pDato);

        // Si no hay nodos encontrados salimos 
        if(nodoEncontrado == null){
            return; 
        }

        // Hacer el salto de nodo 
        nodoAnterior.Siguiente = nodoEncontrado.Siguiente;
        // Quitar nodo de la lista (recolector de basura)
        nodoEncontrado.Siguiente = null;
     }



}