using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tester : MonoBehaviour
{
    public Button _spawnMany;
    public Button _spawnOne;
    public TextMeshProUGUI _debugLog;

    public GameObject _imadgePrefab;
    public GameObject _imadgesPrefab;
    public Transform _parent;
    // Start is called before the first frame update
    void Start()
    {
        _spawnMany.onClick.AddListener(() =>
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            SpawnImaged();
            stopwatch.Stop();
            _debugLog.text = stopwatch.ElapsedMilliseconds.ToString();
        });

        _spawnOne.onClick.AddListener(() =>
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Instantiate(_imadgesPrefab, _parent);
            stopwatch.Stop();
            _debugLog.text = stopwatch.ElapsedMilliseconds.ToString();
        });
    }

    private void SpawnImaged()
    {
         
        var count = 40 * 40;

        for (int i = 0; i < count; i++)
        {
            Instantiate(_imadgePrefab, _parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
