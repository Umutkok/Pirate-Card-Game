using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class ShipController : MonoBehaviour
{
public Animator cannonanim;

[Header("BulletSpawnPoints")]
public GameObject bullet;
public GameObject bullet2;
public GameObject bullet3;
public GameObject bullet4;
public Transform BulletSpawnPoint;

[Header("VFX Spawn Points")]
public GameObject vfxObject;
public Transform vfxTransform_1;
public Transform vfxTransform_2;
public Transform vfxTransform_3;
public Transform vfxTransform_4;

public void Start()
{

}
public void spawnbullet1()
{
Instantiate(bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_1.position, vfxTransform_1.rotation);
}

public void spawnbullet2()
{
StartCoroutine(bulletvfx2());
IEnumerator bulletvfx2()
{
Instantiate(bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_1.position, vfxTransform_1.rotation);
yield return new WaitForSeconds(0.5f);
Instantiate(bullet2, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_2.position, vfxTransform_2.rotation);
}
}

public void spawnbullet3()
{
StartCoroutine(bulletvfx3());
IEnumerator bulletvfx3()
{
Instantiate(bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_1.position, vfxTransform_1.rotation);
yield return new WaitForSeconds(0.5f);
Instantiate(bullet2, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_2.position, vfxTransform_2.rotation);
yield return new WaitForSeconds(0.5f);
Instantiate(bullet3, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_3.position, vfxTransform_3.rotation);
}
}

public void spawnbullet4()
{
StartCoroutine(bulletvfx4());
IEnumerator bulletvfx4()
{
Instantiate(bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_1.position, vfxTransform_1.rotation);
yield return new WaitForSeconds(0.5f);
Instantiate(bullet2, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_2.position, vfxTransform_2.rotation);
yield return new WaitForSeconds(0.5f);
Instantiate(bullet3, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_3.position, vfxTransform_3.rotation);
yield return new WaitForSeconds(0.5f);
Instantiate(bullet4, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
Instantiate(vfxObject, vfxTransform_4.position, vfxTransform_4.rotation);
}
}

}
