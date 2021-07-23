using System; 

class Nodo{
    // Los datos que vamos a almacenar 
    private string dato;

    // Crear una variable que haga referencia al nodo siguiente 
    private Nodo siguiente = null;

    // Propiedades setter y getter 

    public string Dato {get => dato; set => dato = value; } // propiedad que le permite obtener el valor 
    
    internal Nodo Siguiente {get => siguiente; set => siguiente = value; }

    // verlo mas facil 
    public override string ToString(){
        
        return string.Format("[{0}]", dato);

    }

}