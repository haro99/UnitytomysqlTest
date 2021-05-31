using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
public class NewBehaviourScript2 : MonoBehaviour
{
    private void Start()
    {
        MySqlConnection con = new MySqlConnection("server=MYSQLDB; uid=root;pwd=password;database=tekitoo");

        try
        {
            con.Open();
            string sql = "Select * from tableName";
            MySqlCommand com = new MySqlCommand(sql, con);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Debug.Log(reader[0]);
            }
            reader.Close();
        }
        catch (MySqlException e)
        {
            //Debug.Log(e.ToString());
            Debug.Log("データを取得できませんでした");
        }

        Debug.Log("");
    }
}
