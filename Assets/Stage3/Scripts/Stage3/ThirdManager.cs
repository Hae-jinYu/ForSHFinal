using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdManager : MonoBehaviour
{
    public ElfController elf;
    public Text gemCountTxt;
    public Text heartTxt;

    private void Awake()
    {
        

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gemCountTxt.text = elf.gemCurr+" / " + elf.gemCounts;
        heartTxt.text = string.Format("{0:n0}", elf.heart);
    }
}
