using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JournalManager : MonoBehaviour
{
    public static JournalManager Instance;

    [Header("Journal UI")]
    public GameObject journalCanvas;
    public TMP_Text noteText;

    [Header("Player")]
    public Transform centerEye;

    [Header("Settings")]
    public float spawnDistance = 0.7f;
    public float verticalOffset = -0.1f;

    private List<string> notes = new List<string>();

    private int currentNoteIndex = 0;

    private bool isOpen = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        // Temporary during development
        if (Input.GetKeyDown(KeyCode.J)) 
        {
            ToggleJournal();
        }
    }

    public void AddNote(string text)
    {
        notes.Add(text);

        currentNoteIndex = notes.Count - 1;

        OpenJournal();
    }

    public void ToggleJournal()
    {
        if (notes.Count == 0)
            return;

        if (isOpen)
            CloseJournal();
        else
            OpenJournal();
    }

    public void OpenJournal()
    {
        if (notes.Count == 0)
            return;

        isOpen = true;

        journalCanvas.SetActive(true);

        Vector3 position =
            centerEye.position +
            centerEye.forward * spawnDistance +
            Vector3.up * verticalOffset;

        journalCanvas.transform.position = position;

        Vector3 lookDir =
            journalCanvas.transform.position - centerEye.position;

        journalCanvas.transform.rotation =
            Quaternion.LookRotation(lookDir);

        ShowCurrentNote();
    }

    public void CloseJournal()
    {
        isOpen = false;

        journalCanvas.SetActive(false);
    }

    public void NextNote()
    {

        Debug.Log("NEXT");
        
        if (notes.Count == 0)
            return;

        currentNoteIndex++;

        if (currentNoteIndex >= notes.Count)
            currentNoteIndex = 0;

        ShowCurrentNote();
    }

    public void PreviousNote()
    {

        Debug.Log("PREVIOUS");

        if (notes.Count == 0)
            return;

        currentNoteIndex--;

        if (currentNoteIndex < 0)
            currentNoteIndex = notes.Count - 1;

        ShowCurrentNote();
    }

    private void ShowCurrentNote()
    {
        noteText.text = notes[currentNoteIndex];
    }
}