using System.Data;

namespace DAD_UT1_TareaFormDataTable_IntentoUno

    // NOTA IMPORTANTE: El data grid, en conjunto con el DataSource, generan automáticamente las columnas, por eso, cuando las hice manuales, me aparecieron más
{

    // Vale, este intento corresponde a la utilización de DataTable para hacer los ComboBox, mi otra opción eran las listas
    // Funcionará? Ni idea, imitaré lo que vi en el código del profesor con la esperanza de que no explote
    // Anotaré paso por paso

    public partial class Form1 : Form
    {
        //Primero se instancia el objeto, eso si se hacerlo
        private DataTable tablaDatos = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        // Me maté la cabeza viendo como hacer los listener y resulta que salen solos al hacer doble clic. Acuérdate de eso
        // para futuros exámenes

        /*Otra nota: object sender es una referencia del control que provocó el evento
         sender es el que disparó la acción en específico (un botón o lo que sea) y se pone Object en referencia a cualquiera de los objetos,
        ya sea un botón, un ComboBox o lo que sea, es genérico (así lo entendí).*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No sé exactamente que hacer aquí, luego le pregunto al profe
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí se coloca lo que sale al abrir el formulario
            CargarGrilla();
            CargarCategoria();

        }

        // Aquí está el famoso SelectedIndexChange, algo lógico tratándose de un ComboBox
        // Pensé que era algo específico que debía colocar en el código, disculpen
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Listener del cambio de categoria
            CargarEquipos();

        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí realmente no sucede nada cuando lo accionas, todo lo hace la categoria
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Aqui ponemos otra condicional para asegurarse de que elija algo en ambos ComboBox
            if (cbCategoria.SelectedItem != null && cbEquipo.SelectedItem != null)
            {
                // Se lee el texto seleccionado en los combos
                string categoriaTexto = cbCategoria.Text;
                string equipoTexto = cbEquipo.Text;

                // Aquí se añade la fila al DataTable, se actualiza sola por el Databinding
                tablaDatos.Rows.Add(categoriaTexto,  equipoTexto);
            }
        }

        // Vale, el profesor nos pidió tres métodos, aquí van:

        // 1. CargarGrilla (tabla). La idea es poner las dos columnas 
        private void CargarGrilla()
        {
            tablaDatos.Columns.Add("Categorías",  typeof(string));
            tablaDatos.Columns.Add("Equipos", typeof(string));

            /*Este es el famoso DataBinding. Pense que era otra línea de código
             y resulta que es lo que sucede junto con el DataSource, que es cargar el contenido*/
            dgvTabla.DataSource = tablaDatos;
        }

        // 2. Cargar Categoría (ComboBox). Cargamos los ComboBox con DataTable como vimos en el ejemplo de clase
        private void CargarCategoria()
        {
            // Creamos un nuevo DataTable
            DataTable dtCategorias = new DataTable();
            dtCategorias.Columns.Add("IdCategoria", typeof(int));
            dtCategorias.Columns.Add("NombreCategoria", typeof(string));

            // Ahora, en vez de Columns, serán Rows, donde se insertan los datos de la columna
            // Vamos, como una base de datos
            dtCategorias.Rows.Add(1, "Fútbol");
            dtCategorias.Rows.Add(2, "Basket");
            dtCategorias.Rows.Add(3, "BalonMano");

            // Esto lo tube que sacar de internet porque no quería que se viera el ID, solo quería el nombre
            cbCategoria.DisplayMember = "NombreCategoria"; // Esto hace que este sea visible (display)
            cbCategoria.ValueMember = "IdCategoria"; // Esto si lo quieres más rollo interno
            // Ahora sí, DataSource
            cbCategoria.DataSource = dtCategorias;
        }

        /* 3. Cargar Equipo (ComboBox). Aquí se me ocurrió recurrir a un examen viejo que hicimos con
        Jacinto el año pasado, donde debiamos listar ciertas cosas sobre equipos de BalonMano. Como
        debíamos hacerlo sin Vectores ni Matrices, hice una solución con Switch Case. */

        private void CargarEquipos()
        {
            // Se hace lo mismo que arriba, pero aplicando un if y un switch case para la selección. También
            // agrego una condicional por si no se selecciona nada, que es igual en Java
            // Nota: Se coloca el nombre del ComboBox, no el de la tabla
            if (cbCategoria.SelectedValue == null) return;

            DataTable dtEquipos = new DataTable();
            dtEquipos.Columns.Add("IdEquipos", typeof(int));
            dtEquipos.Columns.Add("NombreEquipos", typeof(string));

            // IMPORTANTE: En C# se usa 'is' en la condicional que quiero agregar
            // "Si el valor seleccionado en el cbCategoria es(is) int (entero) idCategora, entonces... (switch case)

            if (cbCategoria.SelectedValue is int idCategoria) {

                switch (idCategoria)
                {
                    case 1: // Fútbol
                        dtEquipos.Rows.Add(101, "Real Madrid");
                        dtEquipos.Rows.Add(102, "FC Barcelona");
                        dtEquipos.Rows.Add(103, "Vinotinto");
                        break;
                    case 2: // Basket
                        dtEquipos.Rows.Add(201, "CB Gran Canaria");
                        dtEquipos.Rows.Add(202, "CB San Isidro");
                        dtEquipos.Rows.Add(203, "CB Las Palmas");
                        break;
                    case 3:
                        dtEquipos.Rows.Add(301, "Club Gáldar");
                        dtEquipos.Rows.Add(302, "Club Perdoma");
                        dtEquipos.Rows.Add(303, "Club Zonzamas");
                        break;
                }
            }

            // Ahora finalizamos igual que con las categorías: Id invisible y nombre visible
            cbEquipo.DisplayMember = "NombreEquipos";
            cbEquipo.ValueMember = "IdEquipos";
            cbEquipo.DataSource = dtEquipos;
        }
        
    }
}
