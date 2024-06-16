/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 24/10/2022
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PRJ_AGAENDA1
{
	/// <summary>
	/// Description of AcessoDados.
	/// </summary>
	public class AcessoDados
	{
		public MySqlConnection AbrirConexão()
		{
			string strconexao = "server=localhost; uid=root; password=polimigmysql; database=bdcontatos";
			MySqlConnection BancoDados;
			try
			{
				BancoDados= new MySqlConnection(strconexao);
				Messagebox.Show("Conexao bem sucedida!");
				return BancoDados;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão com o banco | "+ex.ToString(), "Avisa|", MessageBoxButtons.OK,MessageBox.Icon.Error);
			}
			return null;
			}
		}
	
	public void Inserir(string nomeaux, stringemailaux, string telefoneaux)
	{
		MySqlConnection conexao;
		MySqlCommand cmd;
		string Sql;
		
		conexao = abrirConexao();
		try
		{
			if (conexao!=null)
			{
				sql = "insert into pessoas values (null, '" + nomeaux + "', '"+emailaux+"','"+telefoneaux"')";
				cmd = new MySqlCommand(Sql,conexao);
				cmd.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Erro na gravação:" + ex.toString(),"Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		finally
		{
			conexao.Close();
		}
	}
	
	public void Alterar(int idaux, string nomeaux, string emailaux, string telefoneaux)
	{
		MySqlConnection conexao;
		MySqlCommand cmd;
		string Sql;
		
		conexao = AbrirConexao();
		try {
			if (conexao!=null){
				Sql = "update pessoas set nome ='" + nomeaux + "', email='"+emailaux+"', telefone='" + telefoneaux +"' where id = " + idaux;
				cmd = new MySqlCommand(Sql, conexao);
				cmd.executeNonQuery();
			}
		}
		catch (Exception ex) {
			MessageBox.Show("Erro na alteração:" + ex.toString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		finally {
			conexao.Close();
		}
	}
	
	public void Excluir(int idaux) {
		MySqlConnection conexao;
		MySqlCommand cmd;
		string Sql;
		
		conexao = AbrirConexao();
		try {
			if (conexao!=null) {
				Sql="delete from pessoas where id = " + idaux;
				cmd = new MySqlCommand(Sql, conexao);
				cmd.ExecuteNonQuery();
			}
		}
		catch (Exception ex) {
			MessageBox.Show("Erro na exclusão:" + ex.toString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcons.Warning);
		}
		finally {
			conexao.Close();
		}
	}
	
	public DataTable Consultar(string filtro) {
		MySqlConnection conexao;
		MySqlCommand cmd;
		string Sql;
		
		conexao = AbrirConexao();
		try {
			if (conexao != null) {
				Sql = "select * from pessoas where " + filtro;
				cmd = new MySqlCommand(Sql, conexao);
				cmd.CommandType=CommandType.Text;
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable registros = new DataTable();
				da.Fill(registros);
				conexao.Close();
				return registros;
			}
		}
		catch (Exception ex) {
			MessageBox.Show("Erro na consulta: " + ex.toString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcons.Warning);
		}
		finally {
			conexao.Close();
		}
		return null;
	}
		
		}
	

