using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class formuladisplaymanager : MonoBehaviour
{
    public TextMeshProUGUI AnionText;
    public TextMeshProUGUI CationText;
    public TextMeshProUGUI GasText;

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
    public GameObject IronTest2;
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
    public TextMeshProUGUI IronTest2Text;
    public TextMeshProUGUI ZincTestText;

    public TextMeshProUGUI AmmoniaTestText;
    public TextMeshProUGUI CarbonDioxideTestText;
    public TextMeshProUGUI ChlorineTestText;
    public TextMeshProUGUI HydrogenTestText;
    public TextMeshProUGUI OxygenTestText;


    private enum AnionState { None, Carbonate, Chloride, Iodide, Nitrate, Sulfate }
    private enum CationState { None, Ammonium, Calcium, Copper, Iron, Iron2, Zinc }
    private enum GasState { None, Ammonia, CarbonDioxide, Chlorine, Hydrogen, Oxygen }

    void Start()
    {
        DisplayAnionFormula();
        DisplayCationFormula();
        DisplayGasFormula();
    }

    private void DisplayAnionFormula()
    {
        AnionState currentAnionState = (AnionState)PlayerPrefs.GetInt("AnionState", 0);

        // Deactivate all Anion tests first
        DeactivateAnionTests();

        switch (currentAnionState)
        {
            case AnionState.Carbonate:
                AnionText.text = "CO3²- + Acid = CO2 (gas)";
                CarbonateTest.SetActive(true);
                break;
            case AnionState.Chloride:
                AnionText.text = "Cl- + AgNO3 = AgCl (white ppt)";
                ChlorideTest.SetActive(true);
                break;
            case AnionState.Iodide:
                AnionText.text = "I- + Pb(NO3)2 = PbI2 (yellow ppt)";
                IodideTest.SetActive(true);
                break;
            case AnionState.Nitrate:
                AnionText.text = "NO3- + Al + NaOH = NH3 (gas)";
                NitrateTest.SetActive(true);
                break;
            case AnionState.Sulfate:
                AnionText.text = "SO4²⁻ + Ba(NO3)2 = BaSO4 (white ppt)";
                SulfateTest.SetActive(true);
                break;
            default:
                AnionText.text = "";
                break;
        }
    }

    private void DisplayCationFormula()
    {
        CationState currentCationState = (CationState)PlayerPrefs.GetInt("CationState", 0);

        // Deactivate all Cation tests first
        DeactivateCationTests();

        switch (currentCationState)
        {
            case CationState.Ammonium:
                CationText.text = "NH4+ + NaOH = NH3 (gas)";
                AmmoniumTest.SetActive(true);
                break;
            case CationState.Calcium:
                CationText.text = "Ca2⁺ + NaOH = Ca(OH)2 (white ppt)";
                CalciumTest.SetActive(true);
                break;
            case CationState.Copper:
                CationText.text = "Cu²⁺ + NaOH = Cu(OH)2 (light blue ppt)";
                CopperTest.SetActive(true);
                break;
            case CationState.Iron:
                CationText.text = "Fe3⁺ + NaOH = Fe(OH)3 (red-brown ppt)";
                IronTest.SetActive(true);
                break;
            case CationState.Iron2:
                CationText.text = "Fe3⁺ + NaOH = Fe(OH)3 (red-brown ppt)";
                IronTest.SetActive(true);
                break;
            case CationState.Zinc:
                CationText.text = "Zn²⁺ + NaOH = Zn(OH)2 (white ppt)";
                ZincTest.SetActive(true);
                break;
            default:
                CationText.text = "";
                break;
        }
    }

    private void DisplayGasFormula()
    {
        GasState currentGasState = (GasState)PlayerPrefs.GetInt("GasState", 0);

        // Deactivate all Gas tests first
        DeactivateGasTests();

        switch (currentGasState)
        {
            case GasState.Ammonia:
                GasText.text = "NH3 turns damp red litmus paper blue";
                AmmoniaTest.SetActive(true);
                break;
            case GasState.CarbonDioxide:
                GasText.text = "CO2 + Ca(OH)2 = CaCO3 (white ppt)";
                CarbonDioxideTest.SetActive(true);
                break;
            case GasState.Chlorine:
                GasText.text = "Cl2 bleaches damp litmus paper";
                ChlorineTest.SetActive(true);
                break;
            case GasState.Hydrogen:
                GasText.text = "H2 'pops' with a lighted splint";
                HydrogenTest.SetActive(true);
                break;
            case GasState.Oxygen:
                GasText.text = "O2 relights a glowing splint";
                OxygenTest.SetActive(true);
                break;
            default:
                GasText.text = "";
                break;
        }

    }


       public void carbonateattach()
        {
            volcarb1.SetActive(false);
            volcarb2.SetActive(true);
            CarbonateTestText.text = "Carbonate";
        }

        public void amoniumattach()
        {
            AmmoniumTestText.text = "Ammonium";
        }

        public void chlorideattach()
        {
            ChlorideTestText.text = "Chloride";
        }

        public void nitrateattach()
        {
            NitrateTestText.text = "Nitrate";
        }

        public void sulfateattach()
        {
            SulfateTestText.text = "Sulfate";
        }

        public void carbondioxideattach()
        {
            CarbonDioxideTestText.text = "Carbon Dioxide";
        }

        public void copperattach()
        {
            copperObj.GetComponent<Renderer>().material = copperMat;
            CopperTestText.text = "Copper";
        }

        public void amoniaattach()
        {
            litmuspaper.GetComponent<Renderer>().material = blueMat;
            AmmoniaTestText.text = "Ammonia";
        }

        public void chlorineattach()
        {
            chlorinelitmuspaper.GetComponent<Renderer>().material = chlorineMat;
            ChlorineTestText.text = "Chlorine";
        }

        public void iodideattach()
        {
            iodideObj.GetComponent<Renderer>().material = iodideMat;
            IodideTestText.text = "Iodide";
        }

        public void ironattach()
        {
            ironObj.GetComponent<Renderer>().material = ironMat;
            IronTestText.text = "Iron";
        }

        public void hydrogenattach()
        {
            hydrogenAudio.Play();
            hydrogenObj.GetComponent<Renderer>().material = hydrogenMat;
            HydrogenTestText.text = "Hydrogen";
        }

        public void oxygenattach()
        {
            oxygenObj.SetActive(true);
            OxygenTestText.text = "Oxygen";
        }

        public void zincattach()
        {
            ZincTestText.text = "Zinc";
        }

        public void calciumattach()
        {
            CalciumTestText.text = "Calcium";
        }

        private void DeactivateAnionTests()
        {
            CarbonateTest.SetActive(false);
            ChlorideTest.SetActive(false);
            IodideTest.SetActive(false);
            NitrateTest.SetActive(false);
            SulfateTest.SetActive(false);
        }
    

    private void DeactivateCationTests()
    {
        AmmoniumTest.SetActive(false);
        CalciumTest.SetActive(false);
        CopperTest.SetActive(false);
        IronTest.SetActive(false);
        ZincTest.SetActive(false);
    }

    private void DeactivateGasTests()
    {
        AmmoniaTest.SetActive(false);
        CarbonDioxideTest.SetActive(false);
        ChlorineTest.SetActive(false);
        HydrogenTest.SetActive(false);
        OxygenTest.SetActive(false);
    }

    public void instantiateobject(GameObject objectToInstantiate)
    {
        GameObject obj = Instantiate(objectToInstantiate, objectToInstantiate.transform.position, objectToInstantiate.transform.rotation);
       
    }
}
