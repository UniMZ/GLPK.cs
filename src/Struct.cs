namespace UniMZ.GLPK;

using System.Runtime.InteropServices;

public static partial class GLPK
{
    // basis factorization control parameters
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BFCP
    {
        public int msg_lev; // (not used)
        public int type; // factorization type
        public int lu_size; // (not used)
        public double piv_tol; // sgf_piv_tol
        public int piv_lim; // sgf_piv_lim
        public int suhl; // sgf_suhl
        public double eps_tol; // sgf_eps_tol
        public double max_gro; // (not used)
        public int nfs_max; // fhvint.nfs_max
        public double upd_tol; // (not used)
        public int nrs_max; // scfint.nn_max
        public int rs_size; // (not used)
        public fixed double foo_bar[38]; // (reserved)
    }

    // simplex solver control parameters
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SMCP
    {
        public int msg_lev; // message level
        public int meth; // simplex method option
        public int pricing; // pricing technique
        public int r_test; // ratio test technique
        public double tol_bnd; // primal feasibility tolerance
        public double tol_dj; // dual feasibility tolerance
        public double tol_piv; // pivot tolerance
        public double obj_ll; // lower objective limit
        public double obj_ul; // upper objective limit
        public int it_lim; // simplex iteration limit
        public int tm_lim; // time limit, ms
        public int out_frq; // display output frequency, ms
        public int out_dly; // display output delay, ms
        public int presolve; // enable/disable using LP presolver
        public int excl; // exclude fixed non-basic variables
        public int shift; // shift bounds of variables to zero
        public int aorn; // option to use A or N
        public fixed double foo_bar[33]; // (reserved)
    }

    // interior-point solver control parameters
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IPTCP
    {
        public int msg_lev; // message level (see glp_smcp)
        public int ord_alg; // ordering algorithm
        public fixed double foo_bar[48]; // (reserved)
    }

    // integer optimizer control parameters
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IOCP
    {
        public int msg_lev; // message level (see glp_smcp)
        public int br_tech; // branching technique
        public int bt_tech; // backtracking technique
        public double tol_int; // mip.tol_int
        public double tol_obj; // mip.tol_obj
        public int tm_lim; // mip.tm_lim (milliseconds)
        public int out_frq; // mip.out_frq (milliseconds)
        public int out_dly; // mip.out_dly (milliseconds)
        public IntPtr cb_func; // mip.cb_func
        public IntPtr cb_info; // mip.cb_info
        public int cb_size; // mip.cb_size
        public int pp_tech; // preprocessing technique
        public double mip_gap; // relative MIP gap tolerance
        public int mir_cuts; // MIR cuts       (ON/OFF)
        public int gmi_cuts; // Gomory's cuts  (ON/OFF)
        public int cov_cuts; // cover cuts     (ON/OFF)
        public int clq_cuts; // clique cuts    (ON/OFF)
        public int presolve; // enable/disable using MIP presolver
        public int binarize; // try to binarize integer variables
        public int fp_heur; // feasibility pump heuristic
        public int ps_heur; // proximity search heuristic
        public int ps_tm_lim; // proxy time limit, milliseconds
        public int sr_heur; // simple rounding heuristic
        public int use_sol; // use existing solution
        public IntPtr save_sol; // filename to save every new solution
        public int alien; // use alien solver
        public int flip; // use long-step dual simplex
        public fixed double foo_bar[23]; // (reserved)
    }

    // additional row attributes
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Attr
    {
        public int level; // subproblem level at which the row was added
        public int origin; // row origin flag
        public int klass; // row class descriptor
        public fixed double foo_bar[7]; // (reserved)
    }

    // MPS format control parameters
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MPSCP
    {
        public int blank; // character code to replace blanks in symbolic names
        public IntPtr obj_name; // objective row name
        public double tol_mps; // zero tolerance for MPS data
        public fixed double foo_bar[17]; // (reserved for use in the future)
    }

    // CPLEX LP format control parameters
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CPXCP
    {
        public fixed double foo_bar[20]; // (reserved for use in the future)
    }

    // graph descriptor
    [StructLayout(LayoutKind.Sequential)]
    public struct Graph
    {
        public IntPtr pool; // DMP *pool; memory pool to store graph components
        public IntPtr name; // graph name (1 to 255 chars); NULL means no name is assigned to the graph
        public int nv_max; // length of the vertex list (enlarged automatically)
        public int nv; // number of vertices in the graph, 0 <= nv <= nv_max
        public int na; // number of arcs in the graph, na >= 0
        public IntPtr v; // glp_vertex *v[1+nv_max];  v[i], 1 <= i <= nv, is a pointer to i-th vertex

        public IntPtr
            index; // AVL *index; vertex index to find vertices by their names; NULL means the index does not exist

        public int v_size; // size of data associated with each vertex (0 to 256 bytes)
        public int a_size; // size of data associated with each arc (0 to 256 bytes)
    }

    // vertex descriptor
    [StructLayout(LayoutKind.Sequential)]
    public struct Vertex
    {
        public int i; // vertex ordinal number, 1 <= i <= nv
        public IntPtr name; // vertex name (1 to 255 chars); NULL means no name is assigned to the vertex

        public IntPtr
            entry; // AVLNODE *entry; pointer to corresponding entry in the vertex index; NULL means that either the index does not exist or the vertex has no name assigned

        public IntPtr data; // pointer to data associated with the vertex
        public IntPtr temp; // working pointer
        public IntPtr in_; // pointer to the (unordered) list of incoming arcs
        public IntPtr out_; // pointer to the (unordered) list of outgoing arcs
    }

    // arc descriptor
    [StructLayout(LayoutKind.Sequential)]
    public struct Arc
    {
        public IntPtr tail; // pointer to the tail endpoint
        public IntPtr head; // pointer to the head endpoint
        public IntPtr data; // pointer to data associated with the arc
        public IntPtr temp; // working pointer
        public IntPtr t_prev; // pointer to previous arc having the same tail endpoint
        public IntPtr t_next; // pointer to next arc having the same tail endpoint
        public IntPtr h_prev; // pointer to previous arc having the same head endpoint
        public IntPtr h_next; // pointer to next arc having the same head endpoint
    }
}
