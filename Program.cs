using System;
using System.Collections.Generic;

class Nodo
{
    public string valor;
    public Nodo izquierdo;
    public Nodo derecho;
    public Nodo(string valor)
    {
        this.valor = valor;
        this.izquierdo = null;
        this.derecho = null;
    }
}

class ArbolBinario 
{
    public Nodo raiz;
    public ArbolBinario()
    {
        raiz = null;
    }

    public void preOrden(Nodo nodo) // VID 
    {
        if (nodo != null)
        {
            Console.Write(nodo.valor + " ");
            preOrden(nodo.izquierdo);
            preOrden(nodo.derecho);
        }
    }
    
    public void inOrden(Nodo nodo) {
        if( nodo != null) {
            inOrden(nodo.izquierdo);
            Console.Write(nodo.valor + " ");
            inOrden(nodo.derecho);

        }
    }

    public void postOrden(Nodo nodo) {
        if( nodo != null) {
            postOrden(nodo.izquierdo);
            postOrden(nodo.derecho);
            Console.Write(nodo.valor + " ");
        }
    }
}

class Program
{
    static void Main(){
       ArbolBinario arbol = new ArbolBinario();
       // Crear arbol binario
         arbol.raiz = new Nodo("A");
         arbol.raiz.izquierdo = new Nodo("B");
         arbol.raiz.derecho = new Nodo("C");
         arbol.raiz.izquierdo.izquierdo = new Nodo("D");
         arbol.raiz.izquierdo.derecho = new Nodo("E");
         arbol.raiz.derecho.izquierdo = new Nodo("F");
         arbol.raiz.derecho.derecho = new Nodo("G");

         Console.WriteLine("Recorrido preOrden");
         arbol.preOrden(arbol.raiz);

         Console.WriteLine("\nRecorrido inOrden");
         arbol.inOrden(arbol.raiz);

         Console.WriteLine("\nRecorrido postOrden");
         arbol.postOrden(arbol.raiz);         
       
    }
}


// Tarea 
// Menu
// Ingresar valores dinamicamente
// Determinar la altura
// Determinar el grado y el orden 
// Imprimir el arbol graficamente (que parezca realmente un arbol)
// Buscar valor en el arbol y determinar  en los 3 recorridos como lo hizo, por lo tanto evaluar cual de los 3 es mas optimo para un determinado valor.
