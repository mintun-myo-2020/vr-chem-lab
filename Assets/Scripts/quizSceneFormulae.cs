using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class quizSceneFormulae : MonoBehaviour
{
    
    public GameObject volcarb1;
    public GameObject volcarb2;

    public GameObject litmuspaper;
    public Material blueMat;

    public GameObject iodideObj;
    public Material iodideMat;

    public GameObject copperObj;
    public Material copperMat;

    public GameObject ironObj;
    public Material ironMat;

    public GameObject hydrogenObj;
    public Material hydrogenMat;
    public AudioSource hydrogenAudio;

    public GameObject chlorinelitmuspaper;
    public Material chlorineMat;

    public GameObject oxygenObj;

    // GameObjects representing each test
    public GameObject CarbonateTest;
    public GameObject ChlorideTest;
    public GameObject IodideTest;
    public GameObject NitrateTest;
    public GameObject SulfateTest;

    public GameObject AmmoniumTest;
    public GameObject CalciumTest;
    public GameObject CopperTest;
    public GameObject IronTest;
    public GameObject ZincTest;

    public GameObject AmmoniaTest;
    public GameObject CarbonDioxideTest;
    public GameObject ChlorineTest;
    public GameObject HydrogenTest;
    public GameObject OxygenTest;
    
    
    public TextMeshProUGUI CarbonateTestText;
    public TextMeshProUGUI ChlorideTestText;
    public TextMeshProUGUI IodideTestText;
    public TextMeshProUGUI NitrateTestText;
    public TextMeshProUGUI SulfateTestText;

    public TextMeshProUGUI AmmoniumTestText;
    public TextMeshProUGUI CalciumTestText;
    public TextMeshProUGUI CopperTestText;
    public TextMeshProUGUI IronTestText;
    public TextMeshProUGUI ZincTestText;

    public TextMeshProUGUI AmmoniaTestText;
    public TextMeshProUGUI CarbonDioxideTestText;
    public TextMeshProUGUI ChlorineTestText;
    public TextMeshProUGUI HydrogenTestText;
    public TextMeshProUGUI OxygenTestText;


    private enum AnionState { None, Carbonate, Chloride, Iodide, Nitrate, Sulfate }
    private enum CationState { None, Ammonium, Calcium, Copper, Iron, Zinc }
    private enum GasState { None, Ammonia, CarbonDioxide, Chlorine, Hydrogen, Oxygen }

    void Start()
    {
        DisableAllTests();  // Disable all tests at the start
      // Check which canvas is enabled and enable a random test accordingly
       
        DisplayAnionFormula();
        DisplayCationFormula();
        DisplayGasFormula();
        EnableRandomAnionTest();
        EnableRandomCationTest();
    }

    private void DisableAllTests()
    {
        // Disable all Anion tests
        CarbonateTest.SetActive(false);
        ChlorideTest.SetActive(false);
        IodideTest.SetActive(false);
        NitrateTest.SetActive(false);
        SulfateTest.SetActive(false);

        // Disable all Cation tests
        AmmoniumTest.SetActive(false);
        CalciumTest.SetActive(false);
        CopperTest.SetActive(false);
        IronTest.SetActive(false);
        ZincTest.SetActive(false);

        // Disable all Gas tests
        AmmoniaTest.SetActive(false);
        CarbonDioxideTest.SetActive(false);
        ChlorineTest.SetActive(false);
        HydrogenTest.SetActive(false);
        OxygenTest.SetActive(false);
    }

  

    private void EnableRandomAnionTest()
    {
        // List of anion tests
        List<GameObject> anionTests = new List<GameObject> { CarbonateTest, ChlorideTest, IodideTest, NitrateTest, SulfateTest };

        // Randomly choose one anion test to activate
        int randomTest = Random.Range(0, anionTests.Count);
        anionTests[randomTest].SetActive(true);
    }

    private void EnableRandomCationTest()
    {
        // List of cation tests
        List<GameObject> cationTests = new List<GameObject> { AmmoniumTest, CalciumTest, CopperTest, IronTest, ZincTest };

        // Randomly choose one cation test to activate
        int randomTest = Random.Range(0, cationTests.Count);
        cationTests[randomTest].SetActive(true);
    }

    private void EnableRandomGasTest()
    {
        // List of gas tests
        List<GameObject> gasTests = new List<GameObject> { AmmoniaTest, CarbonDioxideTest, ChlorineTest, HydrogenTest, OxygenTest };

        // Randomly choose one gas test to activate
        int randomTest = Random.Range(0, gasTests.Count);
        gasTests[randomTest].SetActive(true);
    }

    private void DisplayAnionFormula()
    {
        AnionState currentAnionState = (AnionState)PlayerPrefs.GetInt("AnionState", 0);

        switch (currentAnionState)
        {
            case AnionState.Carbonate:
               // AnionText.text = "CO3²- + Acid = CO₂ (gas)";
                break;
            case AnionState.Chloride:
//                AnionText.text = "Cl- + AgNO3 = AgCl (white ppt)";
                break;
            case AnionState.Iodide:
  //              AnionText.text = "I⁻ + Pb(NO₃)₂ → PbI₂ (yellow ppt)";
                break;
            case AnionState.Nitrate:
    //            AnionText.text = "NO₃⁻ + Al + NaOH → NH₃ (gas)";
                break;
            case AnionState.Sulfate:
      //          AnionText.text = "SO₄²⁻ + Ba(NO₃)₂ → BaSO₄ (white ppt)";
                break;
            default:
        //        AnionText.text = "";
                break;
        }
    }

    private void DisplayCationFormula()
    {
        CationState currentCationState = (CationState)PlayerPrefs.GetInt("CationState", 0);

        switch (currentCationState)
        {
            case CationState.Ammonium:
          //      CationText.text = "NH₄⁺ + NaOH → NH₃ (gas)";
                break;
            case CationState.Calcium:
            //    CationText.text = "Ca²⁺ + NaOH → Ca(OH)₂ (white ppt)";
                break;
            case CationState.Copper:
             //   CationText.text = "Cu²⁺ + NaOH → Cu(OH)₂ (light blue ppt)";
                break;
            case CationState.Iron:
             //   CationText.text = "Fe³⁺ + NaOH → Fe(OH)₃ (red-brown ppt)";
                break;
            case CationState.Zinc:
             //   CationText.text = "Zn²⁺ + NaOH → Zn(OH)₂ (white ppt)";
                break;
            default:
               // CationText.text = "";
                break;
        }
    }

    private void DisplayGasFormula()
    {
        GasState currentGasState = (GasState)PlayerPrefs.GetInt("GasState", 0);

        switch (currentGasState)
        {
            case GasState.Ammonia:
             //   GasText.text = "NH₃ turns damp red litmus paper blue";
                break;
            case GasState.CarbonDioxide:
              //  GasText.text = "CO₂ + Ca(OH)₂ → CaCO₃ (white ppt)";
                break;
            case GasState.Chlorine:
               // GasText.text = "Cl₂ bleaches damp litmus paper";
                break;
            case GasState.Hydrogen:
               // GasText.text = "H₂ 'pops' with a lighted splint";
                break;
            case GasState.Oxygen:
               // GasText.text = "O₂ relights a glowing splint";
                break;
            default:
              //  GasText.text = "";
                break;
        }
    }
    public void instantiateobject(GameObject objectToInstantiate)
    {
        GameObject obj = Instantiate(objectToInstantiate, objectToInstantiate.transform.position, objectToInstantiate.transform.rotation);

    }
}
