using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    private void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(30, 70);
        TankController tankController = new TankController(tankModel, tankView);
    }
}