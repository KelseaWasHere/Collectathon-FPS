using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI keyText;
    // Start is called before the first frame update
    void Start()
    {
        keyText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateText(PlayerInventory inventory)
    {
        keyText.text = inventory.NumberOfKeys.ToString();
    }
}
