using UnityEngine;

namespace RAIJIN
{

    [RequireComponent(typeof(AudioSource))]
    public class SystemSound : MonoBehaviour
    {
        public static SystemSound instance;


        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }


        /// <summary>
        /// ���񭵮Ī�API
        /// </summary>
        /// <param name="sound">�����ɮ�</param>
        /// <param name="rangeVolume">���q�d��</param>
        public void PlaySound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);

            aud.PlayOneShot(sound, volume);

        }

    }


}


