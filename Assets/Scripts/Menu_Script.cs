using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{
    private enum AnionState { None, Carbonate, Chloride, Iodide, Nitrate, Sulfate }
    private AnionState currentAnionState = AnionState.None;

    private enum CationState { None, Ammonium, Calcium, Copper, Iron,Iron2, Zinc }
    private CationState currentCationState = CationState.None;

    private enum GasState { None, Ammonia, CarbonDioxide, Chlorine, Hydrogen, Oxygen }
    private GasState currentGasState = GasState.None;

    public TextMeshProUGUI AnionStateText;
    public TextMeshProUGUI CationStateText;
    public TextMeshProUGUI GasStateText;

    public GameObject MainMenu;
    public GameObject AnionMenu;

    public void Start()
    {
        currentAnionState = (AnionState)PlayerPrefs.GetInt("AnionState", 0);
        UpdateAnionStateText();

        currentCationState = (CationState)PlayerPrefs.GetInt("CationState", 0);
        UpdateCationStateText();

        currentGasState = (GasState)PlayerPrefs.GetInt("GasState", 0);
        UpdateGasStateText();
    }

    public void main_start()
    {
        MainMenu.SetActive(false);
        AnionMenu.SetActive(true);
    }

    public void scene1()
    {
        SceneManager.LoadScene(1);
    }
    public void scene2()
    {
        SceneManager.LoadScene(2);
    }

    // Anion Tests
    public void IncrementAnionState()
    {
        if (currentAnionState < AnionState.Sulfate)
        {
            currentAnionState++;
            PlayerPrefs.SetInt("AnionState", (int)currentAnionState);
            UpdateAnionStateText();
            SaveFormulaForAnion();
        }
    }

    public void DecrementAnionState()
    {
        if (currentAnionState > AnionState.None)
        {
            currentAnionState--;
            PlayerPrefs.SetInt("AnionState", (int)currentAnionState);
            UpdateAnionStateText();
            SaveFormulaForAnion();
        }
    }

    private void UpdateAnionStateText()
    {
        if (AnionStateText != null)
        {
            AnionStateText.text = currentAnionState.ToString();
        }
    }

    private void SaveFormulaForAnion()
    {
        string formula = "";
        switch (currentAnionState)
        {
            case AnionState.Carbonate:
                formula = "CO₃²⁻ + Acid → CO₂ (gas)";
                break;
            case AnionState.Chloride:
                formula = "Cl⁻ + AgNO₃ → AgCl (white ppt)";
                break;
            case AnionState.Iodide:
                formula = "I⁻ + Pb(NO₃)₂ → PbI₂ (yellow ppt)";
                break;
            case AnionState.Nitrate:
                formula = "NO₃⁻ + Al + NaOH → NH₃ (gas)";
                break;
            case AnionState.Sulfate:
                formula = "SO₄²⁻ + Ba(NO₃)₂ → BaSO₄ (white ppt)";
                break;
        }
        PlayerPrefs.SetString("SelectedTestFormula", formula);
    }

    // Cation Tests
    public void IncrementCationState()
    {
        if (currentCationState < CationState.Zinc)
        {
            currentCationState++;
            PlayerPrefs.SetInt("CationState", (int)currentCationState);
            UpdateCationStateText();
            SaveFormulaForCation();
        }
    }

    public void DecrementCationState()
    {
        if (currentCationState > CationState.None)
        {
            currentCationState--;
            PlayerPrefs.SetInt("CationState", (int)currentCationState);
            UpdateCationStateText();
            SaveFormulaForCation();
        }
    }

    private void UpdateCationStateText()
    {
        if (CationStateText != null)
        {
            CationStateText.text = currentCationState.ToString();
        }
    }

    private void SaveFormulaForCation()
    {
        string formula = "";
        switch (currentCationState)
        {
            case CationState.Ammonium:
                formula = "NH₄⁺ + NaOH → NH₃ (gas)";
                break;
            case CationState.Calcium:
                formula = "Ca²⁺ + NaOH → Ca(OH)₂ (white ppt)";
                break;
            case CationState.Copper:
                formula = "Cu²⁺ + NaOH → Cu(OH)₂ (light blue ppt)";
                break;
            case CationState.Iron:
                formula = "Fe³⁺ + NaOH → Fe(OH)₃ (red-brown ppt)";
                break;
            case CationState.Iron2:
                formula = "Fe³⁺ + NaOH → Fe(OH)₃ (red-brown ppt)";
                break;
            case CationState.Zinc:
                formula = "Zn²⁺ + NaOH → Zn(OH)₂ (white ppt)";
                break;
        }
        PlayerPrefs.SetString("SelectedTestFormula", formula);
    }

    // Gas Tests
    public void IncrementGasState()
    {
        if (currentGasState < GasState.Oxygen)
        {
            currentGasState++;
            PlayerPrefs.SetInt("GasState", (int)currentGasState);
            UpdateGasStateText();
            SaveFormulaForGas();
        }
    }

    public void DecrementGasState()
    {
        if (currentGasState > GasState.None)
        {
            currentGasState--;
            PlayerPrefs.SetInt("GasState", (int)currentGasState);
            UpdateGasStateText();
            SaveFormulaForGas();
        }
    }

    private void UpdateGasStateText()
    {
        if (GasStateText != null)
        {
            GasStateText.text = currentGasState.ToString();
        }
    }

    private void SaveFormulaForGas()
    {
        string formula = "";
        switch (currentGasState)
        {
            case GasState.Ammonia:
                formula = "NH₃ turns damp red litmus paper blue";
                break;
            case GasState.CarbonDioxide:
                formula = "CO₂ + Ca(OH)₂ → CaCO₃ (white ppt)";
                break;
            case GasState.Chlorine:
                formula = "Cl₂ bleaches damp litmus paper";
                break;
            case GasState.Hydrogen:
                formula = "H₂ 'pops' with a lighted splint";
                break;
            case GasState.Oxygen:
                formula = "O₂ relights a glowing splint";
                break;
        }
        PlayerPrefs.SetString("SelectedTestFormula", formula);
    }
}
