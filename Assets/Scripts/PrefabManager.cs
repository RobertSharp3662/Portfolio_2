using UnityEngine;

public class PrefabManager : MonoBehaviour{
    // Assign the prefab in the inspector
    public GameObject[] EnemyPrefabs;

    public GameObject enemyBulletPrefab;
    public GameObject ammoPickup;
    public GameObject healthPickup;


    //Singleton
    private static PrefabManager m_Instance = null;
    public static PrefabManager Instance{
        get {
            if (m_Instance == null){
                m_Instance = (PrefabManager)FindObjectOfType(typeof(PrefabManager));
            }
            return m_Instance;
        }
    }
}