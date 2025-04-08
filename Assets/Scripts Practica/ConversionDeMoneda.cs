using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    //1. Declaración de variables
    public float montoAConvertir;
    public string codigoMoneda;

    float montoConvertido;
    float cotizacionMonedaElegida;

    float montoMinimoAConvertir = 1000;
    float cotizacionDolar = 1134.5f;
    float cotizacionEuro = 1397.16f;
    float cotizacionReal = 211.1f;


    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso y validación de datos
        if (montoAConvertir < montoMinimoAConvertir)
        {
            Debug.Log("El monto mínimo es " + montoMinimoAConvertir);
            return; //hace q todo el codigo que este abajo no se ejecute
        }

        if (codigoMoneda == "D")  // las comparaciones se escriben con "=="
        {
            cotizacionMonedaElegida = cotizacionDolar;
        } else if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        } else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = cotizacionReal;
        } else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }

        //3. Operaciones y procesamiento de datos

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //4. Salida de datos
        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
