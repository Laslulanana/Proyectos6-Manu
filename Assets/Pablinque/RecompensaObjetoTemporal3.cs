using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecompensaObjetoTemporal3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D collision)
    {
        Tiempo.espadaTiempo = true;
    }
}
