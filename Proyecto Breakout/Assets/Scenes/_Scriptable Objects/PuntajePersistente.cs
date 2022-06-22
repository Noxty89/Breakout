using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PuntajePersistente : ScriptableObject
{
public void Guardar(string NombreArchivo = null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(ObtenerRuta(NombreArchivo));
        var Json = JsonUtility.ToJson(this);

        bf.Serialize(file, Json);
        file.Close();
    }
public virtual void Cargar(string NombreAarcivo = null)
    {
        if (File.Exists(ObtenerRuta(NombreAarcivo)))
        {
            var bf = new BinaryFormatter();
            var archivo = File.Open(ObtenerRuta(NombreAarcivo), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo), this);
            archivo.Close();
        }
    }
 public string ObtenerRuta(string NombreArchivo = null)
    {
        var NombreArchivoCompleto = string.IsNullOrEmpty(NombreArchivo) ? name : NombreArchivo;
        return string.Format("{0}/{1}.ebac", Application.persistentDataPath, NombreArchivoCompleto);
    }
}
