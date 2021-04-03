using TMPro;
using UnityEngine;

public class PoolController : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI _collectedObjectsText;
    private int _collectedObjects = 0;
    private int _collectionGoal = 4;

    private float _timeRemaining = 1;
    private bool _isTimerRunning = false;
    void Start()
    {
        SetCollectedObjectsText();
    }
    void Update()
    {
        if (_isTimerRunning)
        {
            if (_timeRemaining > 0)
            {
                _timeRemaining -= Time.deltaTime;
            }
            else
            {
                _timeRemaining = 0;
                _isTimerRunning = false;
                CheckCollectedObjectsCount();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        _isTimerRunning = true; 
        if (other.gameObject.CompareTag("CollectableObject"))
        {
            _timeRemaining = 1f;
            _collectedObjects++;
            //other.gameObject.GetComponent<BoxCollider>().enabled = false;
            SetCollectedObjectsText();
        }
    }
    private void CheckCollectedObjectsCount()
    {
        print("Checking Collected Objects Count");
        if (_collectedObjects >= _collectionGoal)
        {
            print("Level Completed");
            CoverThePool();
        }
    }

    private void CoverThePool()
    {
        print("Covering the pool");
    }

    private void SetCollectedObjectsText()
    {
        _collectedObjectsText.text = _collectedObjects + "/" + _collectionGoal;
    }
}
