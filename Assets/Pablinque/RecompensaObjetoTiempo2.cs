using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecompensaObjetoTiempo2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D collision)
    {
        Tiempo.botasTiempo = true;
    }
}
