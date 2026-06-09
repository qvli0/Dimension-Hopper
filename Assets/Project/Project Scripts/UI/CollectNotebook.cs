using UnityEngine;
using System.Collections;
public class CollectNotebook : MonoBehaviour
{

    public Note note;

    public void Collect()
    {
        JournalManager.Instance.AddNote(note.noteText);

        Invoke(nameof(HideObject), 0.1f);
    }

    private void HideObject()
    {
        gameObject.SetActive(false);
    }
}
