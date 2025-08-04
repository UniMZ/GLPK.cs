namespace UniMZ.GLPK;

using System.Runtime.InteropServices;

public static partial class GLPK
{
    // create problem object
    [LibraryImport("GLPK", EntryPoint = "glp_create_prob")]
    public static partial IntPtr CreateProb();

    // assign (change) problem name
    [LibraryImport("GLPK", EntryPoint = "glp_set_prob_name")]
    public static partial void SetProbName(IntPtr prob, IntPtr name);

    // assign (change) objective function name
    [LibraryImport("GLPK", EntryPoint = "glp_set_obj_name")]
    public static partial void SetObjName(IntPtr prob, IntPtr name);

    // set (change) optimization direction flag
    [LibraryImport("GLPK", EntryPoint = "glp_set_obj_dir")]
    public static partial void SetObjDir(IntPtr prob, int dir);

    // add new rows to problem object
    [LibraryImport("GLPK", EntryPoint = "glp_add_rows")]
    public static partial int AddRows(IntPtr prob, int nrs);

    // add new columns to problem object
    [LibraryImport("GLPK", EntryPoint = "glp_add_cols")]
    public static partial int AddCols(IntPtr prob, int ncs);

    // assign (change) row name
    [LibraryImport("GLPK", EntryPoint = "glp_set_row_name")]
    public static partial void SetRowName(IntPtr prob, int i, IntPtr name);

    // assign (change) column name
    [LibraryImport("GLPK", EntryPoint = "glp_set_col_name")]
    public static partial void SetColName(IntPtr prob, int j, IntPtr name);

    // set (change) row bounds
    [LibraryImport("GLPK", EntryPoint = "glp_set_row_bnds")]
    public static partial void SetRowBnds(IntPtr prob, int i, int type, double lb, double ub);

    // set (change) column bounds
    [LibraryImport("GLPK", EntryPoint = "glp_set_col_bnds")]
    public static partial void SetColBnds(IntPtr prob, int j, int type, double lb, double ub);

    // set (change) obj. coefficient or constant term
    [LibraryImport("GLPK", EntryPoint = "glp_set_obj_coef")]
    public static partial void SetObjCoef(IntPtr prob, int j, double coef);

    // set (replace) row of the constraint matrix
    [LibraryImport("GLPK", EntryPoint = "glp_set_mat_row")]
    public static partial void SetMatRow(IntPtr prob, int i, int len, int[] ind, double[] val);

    // set (replace) column of the constraint matrix
    [LibraryImport("GLPK", EntryPoint = "glp_set_mat_col")]
    public static partial void SetMatCol(IntPtr prob, int j, int len, int[] ind, double[] val);

    // load (replace) the whole constraint matrix
    [LibraryImport("GLPK", EntryPoint = "glp_load_matrix")]
    public static partial void LoadMatrix(IntPtr prob, int ne, int[] ia, int[] ja, double[] ar);

    // check for duplicate elements in sparse matrix
    [LibraryImport("GLPK", EntryPoint = "glp_check_dup")]
    public static partial int CheckDup(int m, int n, int ne, int[] ia, int[] ja);

    // sort elements of the constraint matrix
    [LibraryImport("GLPK", EntryPoint = "glp_sort_matrix")]
    public static partial void SortMatrix(IntPtr prob);

    // delete specified rows from problem object
    [LibraryImport("GLPK", EntryPoint = "glp_del_rows")]
    public static partial void DelRows(IntPtr prob, int nrs, int[] num);

    // delete specified columns from problem object
    [LibraryImport("GLPK", EntryPoint = "glp_del_cols")]
    public static partial void DelCols(IntPtr prob, int ncs, int[] num);

    // copy problem object content
    [LibraryImport("GLPK", EntryPoint = "glp_copy_prob")]
    public static partial void CopyProb(IntPtr dest, IntPtr prob, int names);

    // erase problem object content
    [LibraryImport("GLPK", EntryPoint = "glp_erase_prob")]
    public static partial void EraseProb(IntPtr prob);

    // delete problem object
    [LibraryImport("GLPK", EntryPoint = "glp_delete_prob")]
    public static partial void DeleteProb(IntPtr prob);

    // retrieve problem name
    [LibraryImport("GLPK", EntryPoint = "glp_get_prob_name")]
    public static partial IntPtr GetProbName(IntPtr prob);

    // retrieve objective function name
    [LibraryImport("GLPK", EntryPoint = "glp_get_obj_name")]
    public static partial IntPtr GetObjName(IntPtr prob);

    // retrieve optimization direction flag
    [LibraryImport("GLPK", EntryPoint = "glp_get_obj_dir")]
    public static partial int GetObjDir(IntPtr prob);

    // retrieve number of rows
    [LibraryImport("GLPK", EntryPoint = "glp_get_num_rows")]
    public static partial int GetNumRows(IntPtr prob);

    // retrieve number of columns
    [LibraryImport("GLPK", EntryPoint = "glp_get_num_cols")]
    public static partial int GetNumCols(IntPtr prob);

    // retrieve row name
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_name")]
    public static partial IntPtr GetRowName(IntPtr prob, int i);

    // retrieve column name
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_name")]
    public static partial IntPtr GetColName(IntPtr prob, int j);

    // retrieve row type
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_type")]
    public static partial int GetRowType(IntPtr prob, int i);

    // retrieve row lower bound
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_lb")]
    public static partial double GetRowLb(IntPtr prob, int i);

    // retrieve row upper bound
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_ub")]
    public static partial double GetRowUb(IntPtr prob, int i);

    // retrieve column type
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_type")]
    public static partial int GetColType(IntPtr prob, int j);

    // retrieve column lower bound
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_lb")]
    public static partial double GetColLb(IntPtr prob, int j);

    // retrieve column upper bound
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_ub")]
    public static partial double GetColUb(IntPtr prob, int j);

    // retrieve obj. coefficient or constant term
    [LibraryImport("GLPK", EntryPoint = "glp_get_obj_coef")]
    public static partial double GetObjCoef(IntPtr prob, int j);

    // retrieve number of constraint coefficients
    [LibraryImport("GLPK", EntryPoint = "glp_get_num_nz")]
    public static partial int GetNumNz(IntPtr prob);

    // retrieve row of the constraint matrix
    [LibraryImport("GLPK", EntryPoint = "glp_get_mat_row")]
    public static partial int GetMatRow(IntPtr prob, int i, int[] ind, double[] val);

    // retrieve column of the constraint matrix
    [LibraryImport("GLPK", EntryPoint = "glp_get_mat_col")]
    public static partial int GetMatCol(IntPtr prob, int j, int[] ind, double[] val);

    // create the name index
    [LibraryImport("GLPK", EntryPoint = "glp_create_index")]
    public static partial void CreateIndex(IntPtr prob);

    // find row by its name
    [LibraryImport("GLPK", EntryPoint = "glp_find_row")]
    public static partial int FindRow(IntPtr prob, IntPtr name);

    // find column by its name
    [LibraryImport("GLPK", EntryPoint = "glp_find_col")]
    public static partial int FindCol(IntPtr prob, IntPtr name);

    // delete the name index
    [LibraryImport("GLPK", EntryPoint = "glp_delete_index")]
    public static partial void DeleteIndex(IntPtr prob);

    // set (change) row scale factor
    [LibraryImport("GLPK", EntryPoint = "glp_set_rii")]
    public static partial void SetRii(IntPtr prob, int i, double rii);

    // set (change) column scale factor
    [LibraryImport("GLPK", EntryPoint = "glp_set_sjj")]
    public static partial void SetSjj(IntPtr prob, int j, double sjj);

    // retrieve row scale factor
    [LibraryImport("GLPK", EntryPoint = "glp_get_rii")]
    public static partial double GetRii(IntPtr prob, int i);

    // retrieve column scale factor
    [LibraryImport("GLPK", EntryPoint = "glp_get_sjj")]
    public static partial double GetSjj(IntPtr prob, int j);

    // scale problem data
    [LibraryImport("GLPK", EntryPoint = "glp_scale_prob")]
    public static partial void ScaleProb(IntPtr prob, int flags);

    // unscale problem data
    [LibraryImport("GLPK", EntryPoint = "glp_unscale_prob")]
    public static partial void UnscaleProb(IntPtr prob);

    // set (change) row status
    [LibraryImport("GLPK", EntryPoint = "glp_set_row_stat")]
    public static partial void SetRowStat(IntPtr prob, int i, int stat);

    // set (change) column status
    [LibraryImport("GLPK", EntryPoint = "glp_set_col_stat")]
    public static partial void SetColStat(IntPtr prob, int j, int stat);

    // construct standard initial LP basis
    [LibraryImport("GLPK", EntryPoint = "glp_std_basis")]
    public static partial void StdBasis(IntPtr prob);

    // construct advanced initial LP basis
    [LibraryImport("GLPK", EntryPoint = "glp_adv_basis")]
    public static partial void AdvBasis(IntPtr prob, int flags);

    // construct Bixby's initial LP basis
    [LibraryImport("GLPK", EntryPoint = "glp_cpx_basis")]
    public static partial void CpxBasis(IntPtr prob);

    // solve LP problem with the simplex method
    [LibraryImport("GLPK", EntryPoint = "glp_simplex")]
    public static partial int Simplex(IntPtr prob, ref SMCP parm);

    // solve LP problem in exact arithmetic
    [LibraryImport("GLPK", EntryPoint = "glp_exact")]
    public static partial int Exact(IntPtr prob, ref SMCP parm);

    // initialize simplex method control parameters
    [LibraryImport("GLPK", EntryPoint = "glp_init_smcp")]
    public static partial void InitSmcp(out SMCP parm);

    // retrieve generic status of basic solution
    [LibraryImport("GLPK", EntryPoint = "glp_get_status")]
    public static partial int GetStatus(IntPtr prob);

    // retrieve status of primal basic solution
    [LibraryImport("GLPK", EntryPoint = "glp_get_prim_stat")]
    public static partial int GetPrimStat(IntPtr prob);

    // retrieve status of dual basic solution
    [LibraryImport("GLPK", EntryPoint = "glp_get_dual_stat")]
    public static partial int GetDualStat(IntPtr prob);

    // retrieve objective value (basic solution)
    [LibraryImport("GLPK", EntryPoint = "glp_get_obj_val")]
    public static partial double GetObjVal(IntPtr prob);

    // retrieve row status
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_stat")]
    public static partial int GetRowStat(IntPtr prob, int i);

    // retrieve row primal value (basic solution)
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_prim")]
    public static partial double GetRowPrim(IntPtr prob, int i);

    // retrieve row dual value (basic solution)
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_dual")]
    public static partial double GetRowDual(IntPtr prob, int i);

    // retrieve column status
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_stat")]
    public static partial int GetColStat(IntPtr prob, int j);

    // retrieve column primal value (basic solution)
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_prim")]
    public static partial double GetColPrim(IntPtr prob, int j);

    // retrieve column dual value (basic solution)
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_dual")]
    public static partial double GetColDual(IntPtr prob, int j);

    // determine variable causing unboundedness
    [LibraryImport("GLPK", EntryPoint = "glp_get_unbnd_ray")]
    public static partial int GetUnbndRay(IntPtr prob);

    // get simplex solver iteration count
    [LibraryImport("GLPK", EntryPoint = "glp_get_it_cnt")]
    public static partial int GetItCnt(IntPtr prob);

    // set simplex solver iteration count
    [LibraryImport("GLPK", EntryPoint = "glp_set_it_cnt")]
    public static partial void SetItCnt(IntPtr prob, int it_cnt);

    // solve LP problem with the interior-point method
    [LibraryImport("GLPK", EntryPoint = "glp_interior")]
    public static partial int Interior(IntPtr prob, ref IPTCP parm);

    // initialize interior-point solver control parameters
    [LibraryImport("GLPK", EntryPoint = "glp_init_iptcp")]
    public static partial void InitIptcp(out IPTCP parm);

    // retrieve status of interior-point solution
    [LibraryImport("GLPK", EntryPoint = "glp_ipt_status")]
    public static partial int IptStatus(IntPtr prob);

    // retrieve objective value (interior point)
    [LibraryImport("GLPK", EntryPoint = "glp_ipt_obj_val")]
    public static partial double IptObjVal(IntPtr prob);

    // retrieve row primal value (interior point)
    [LibraryImport("GLPK", EntryPoint = "glp_ipt_row_prim")]
    public static partial double IptRowPrim(IntPtr prob, int i);

    // retrieve row dual value (interior point)
    [LibraryImport("GLPK", EntryPoint = "glp_ipt_row_dual")]
    public static partial double IptRowDual(IntPtr prob, int i);

    // retrieve column primal value (interior point)
    [LibraryImport("GLPK", EntryPoint = "glp_ipt_col_prim")]
    public static partial double IptColPrim(IntPtr prob, int j);

    // retrieve column dual value (interior point)
    [LibraryImport("GLPK", EntryPoint = "glp_ipt_col_dual")]
    public static partial double IptColDual(IntPtr prob, int j);

    // set (change) column kind
    [LibraryImport("GLPK", EntryPoint = "glp_set_col_kind")]
    public static partial void SetColKind(IntPtr prob, int j, int kind);

    // retrieve column kind
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_kind")]
    public static partial int GetColKind(IntPtr prob, int j);

    // retrieve number of integer columns
    [LibraryImport("GLPK", EntryPoint = "glp_get_num_int")]
    public static partial int GetNumInt(IntPtr prob);

    // retrieve number of binary columns
    [LibraryImport("GLPK", EntryPoint = "glp_get_num_bin")]
    public static partial int GetNumBin(IntPtr prob);

    // solve MIP problem with the branch-and-bound method
    [LibraryImport("GLPK", EntryPoint = "glp_intopt")]
    public static partial int Intopt(IntPtr prob, ref IOCP parm);

    // initialize integer optimizer control parameters
    [LibraryImport("GLPK", EntryPoint = "glp_init_iocp")]
    public static partial void InitIocp(out IOCP parm);

    // retrieve status of MIP solution
    [LibraryImport("GLPK", EntryPoint = "glp_mip_status")]
    public static partial int MipStatus(IntPtr prob);

    // retrieve objective value (MIP solution)
    [LibraryImport("GLPK", EntryPoint = "glp_mip_obj_val")]
    public static partial double MipObjVal(IntPtr prob);

    // retrieve row value (MIP solution)
    [LibraryImport("GLPK", EntryPoint = "glp_mip_row_val")]
    public static partial double MipRowVal(IntPtr prob, int i);

    // retrieve column value (MIP solution)
    [LibraryImport("GLPK", EntryPoint = "glp_mip_col_val")]
    public static partial double MipColVal(IntPtr prob, int j);

    // check feasibility/optimality conditions
    [LibraryImport("GLPK", EntryPoint = "glp_check_kkt")]
    public static partial void CheckKkt(IntPtr prob, int sol, int cond, ref double ae_max, ref int ae_ind,
        ref double re_max, ref int re_ind);

    // write basic solution in printable format
    [LibraryImport("GLPK", EntryPoint = "glp_print_sol")]
    public static partial int PrintSol(IntPtr prob, IntPtr fname);

    // read basic solution from text file
    [LibraryImport("GLPK", EntryPoint = "glp_read_sol")]
    public static partial int ReadSol(IntPtr prob, IntPtr fname);

    // write basic solution to text file
    [LibraryImport("GLPK", EntryPoint = "glp_write_sol")]
    public static partial int WriteSol(IntPtr prob, IntPtr fname);

    // print sensitivity analysis report
    [LibraryImport("GLPK", EntryPoint = "glp_print_ranges")]
    public static partial int PrintRanges(IntPtr prob, int len, int[] list, int flags, IntPtr fname);

    // write interior-point solution in printable format
    [LibraryImport("GLPK", EntryPoint = "glp_print_ipt")]
    public static partial int PrintIpt(IntPtr prob, IntPtr fname);

    // read interior-point solution from text file
    [LibraryImport("GLPK", EntryPoint = "glp_read_ipt")]
    public static partial int ReadIpt(IntPtr prob, IntPtr fname);

    // write interior-point solution to text file
    [LibraryImport("GLPK", EntryPoint = "glp_write_ipt")]
    public static partial int WriteIpt(IntPtr prob, IntPtr fname);

    // write MIP solution in printable format
    [LibraryImport("GLPK", EntryPoint = "glp_print_mip")]
    public static partial int PrintMip(IntPtr prob, IntPtr fname);

    // read MIP solution from text file
    [LibraryImport("GLPK", EntryPoint = "glp_read_mip")]
    public static partial int ReadMip(IntPtr prob, IntPtr fname);

    // write MIP solution to text file
    [LibraryImport("GLPK", EntryPoint = "glp_write_mip")]
    public static partial int WriteMip(IntPtr prob, IntPtr fname);

    // check if LP basis factorization exists
    [LibraryImport("GLPK", EntryPoint = "glp_bf_exists")]
    public static partial int BfExists(IntPtr prob);

    // compute LP basis factorization
    [LibraryImport("GLPK", EntryPoint = "glp_factorize")]
    public static partial int Factorize(IntPtr prob);

    // check if LP basis factorization has been updated
    [LibraryImport("GLPK", EntryPoint = "glp_bf_updated")]
    public static partial int BfUpdated(IntPtr prob);

    // retrieve LP basis factorization control parameters
    [LibraryImport("GLPK", EntryPoint = "glp_get_bfcp")]
    public static partial void GetBfcp(IntPtr prob, ref BFCP parm);

    // change LP basis factorization control parameters
    [LibraryImport("GLPK", EntryPoint = "glp_set_bfcp")]
    public static partial void SetBfcp(IntPtr prob, ref BFCP parm);

    // retrieve LP basis header information
    [LibraryImport("GLPK", EntryPoint = "glp_get_bhead")]
    public static partial int GetBhead(IntPtr prob, int k);

    // retrieve row index in the basis header
    [LibraryImport("GLPK", EntryPoint = "glp_get_row_bind")]
    public static partial int GetRowBind(IntPtr prob, int i);

    // retrieve column index in the basis header
    [LibraryImport("GLPK", EntryPoint = "glp_get_col_bind")]
    public static partial int GetColBind(IntPtr prob, int j);

    // perform forward transformation (solve system B*x = b)
    [LibraryImport("GLPK", EntryPoint = "glp_ftran")]
    public static partial void Ftran(IntPtr prob, double[] x);

    // perform backward transformation (solve system B'*x = b)
    [LibraryImport("GLPK", EntryPoint = "glp_btran")]
    public static partial void Btran(IntPtr prob, double[] x);

    // "warm up" LP basis
    [LibraryImport("GLPK", EntryPoint = "glp_warm_up")]
    public static partial int WarmUp(IntPtr prob);

    // compute row of the simplex tableau
    [LibraryImport("GLPK", EntryPoint = "glp_eval_tab_row")]
    public static partial int EvalTabRow(IntPtr prob, int k, int[] ind, double[] val);

    // compute column of the simplex tableau
    [LibraryImport("GLPK", EntryPoint = "glp_eval_tab_col")]
    public static partial int EvalTabCol(IntPtr prob, int k, int[] ind, double[] val);

    // transform explicitly specified row
    [LibraryImport("GLPK", EntryPoint = "glp_transform_row")]
    public static partial int TransformRow(IntPtr prob, int len, int[] ind, double[] val);

    // transform explicitly specified column
    [LibraryImport("GLPK", EntryPoint = "glp_transform_col")]
    public static partial int TransformCol(IntPtr prob, int len, int[] ind, double[] val);

    // perform primal ratio test
    [LibraryImport("GLPK", EntryPoint = "glp_prim_rtest")]
    public static partial int PrimRtest(IntPtr prob, int len, int[] ind, double[] val, int dir, double eps);

    // perform dual ratio test
    [LibraryImport("GLPK", EntryPoint = "glp_dual_rtest")]
    public static partial int DualRtest(IntPtr prob, int len, int[] ind, double[] val, int dir, double eps);

    // analyze active bound of non-basic variable
    [LibraryImport("GLPK", EntryPoint = "glp_analyze_bound")]
    public static partial void AnalyzeBound(IntPtr prob, int k, ref double value1, ref int var1, ref double value2,
        ref int var2);

    // analyze objective coefficient at basic variable
    [LibraryImport("GLPK", EntryPoint = "glp_analyze_coef")]
    public static partial void AnalyzeCoef(IntPtr prob, int k, ref double coef1, ref int var1, ref double value1,
        ref double coef2, ref int var2, ref double value2);

    // allocate the preprocessor workspace
    [LibraryImport("GLPK", EntryPoint = "glp_npp_alloc_wksp")]
    public static partial IntPtr NppAllocWksp();

    // load original problem instance
    [LibraryImport("GLPK", EntryPoint = "glp_npp_load_prob")]
    public static partial void NppLoadProb(IntPtr prep, IntPtr prob, int sol, int names);

    // perform basic LP/MIP preprocessing
    [LibraryImport("GLPK", EntryPoint = "glp_npp_preprocess1")]
    public static partial int NppPreprocess1(IntPtr prep, int hard);

    // build resultant problem instance
    [LibraryImport("GLPK", EntryPoint = "glp_npp_build_prob")]
    public static partial void NppBuildProb(IntPtr prep, IntPtr prob);

    // postprocess solution to resultant problem
    [LibraryImport("GLPK", EntryPoint = "glp_npp_postprocess")]
    public static partial void NppPostprocess(IntPtr prep, IntPtr prob);

    // obtain solution to original problem
    [LibraryImport("GLPK", EntryPoint = "glp_npp_obtain_sol")]
    public static partial void NppObtainSol(IntPtr prep, IntPtr prob);

    // free the preprocessor workspace
    [LibraryImport("GLPK", EntryPoint = "glp_npp_free_wksp")]
    public static partial void NppFreeWksp(IntPtr prep);

    // determine reason for calling the callback routine
    [LibraryImport("GLPK", EntryPoint = "glp_ios_reason")]
    public static partial int IosReason(IntPtr T);

    // access the problem object
    [LibraryImport("GLPK", EntryPoint = "glp_ios_get_prob")]
    public static partial IntPtr IosGetProb(IntPtr T);

    // determine size of the branch-and-bound tree
    [LibraryImport("GLPK", EntryPoint = "glp_ios_tree_size")]
    public static partial void IosTreeSize(IntPtr T, ref int a_cnt, ref int n_cnt, ref int t_cnt);

    // determine current active subproblem
    [LibraryImport("GLPK", EntryPoint = "glp_ios_curr_node")]
    public static partial int IosCurrNode(IntPtr T);

    // determine next active subproblem
    [LibraryImport("GLPK", EntryPoint = "glp_ios_next_node")]
    public static partial int IosNextNode(IntPtr T, int p);

    // determine previous active subproblem
    [LibraryImport("GLPK", EntryPoint = "glp_ios_prev_node")]
    public static partial int IosPrevNode(IntPtr T, int p);

    // determine parent subproblem
    [LibraryImport("GLPK", EntryPoint = "glp_ios_up_node")]
    public static partial int IosUpNode(IntPtr T, int p);

    // determine subproblem level
    [LibraryImport("GLPK", EntryPoint = "glp_ios_node_level")]
    public static partial int IosNodeLevel(IntPtr T, int p);

    // determine subproblem local bound
    [LibraryImport("GLPK", EntryPoint = "glp_ios_node_bound")]
    public static partial double IosNodeBound(IntPtr T, int p);

    // find active subproblem with best local bound
    [LibraryImport("GLPK", EntryPoint = "glp_ios_best_node")]
    public static partial int IosBestNode(IntPtr T);

    // compute relative MIP gap
    [LibraryImport("GLPK", EntryPoint = "glp_ios_mip_gap")]
    public static partial double IosMipGap(IntPtr T);

    // access subproblem application-specific data
    [LibraryImport("GLPK", EntryPoint = "glp_ios_node_data")]
    public static partial IntPtr IosNodeData(IntPtr T, int p);

    // retrieve additional row attributes
    [LibraryImport("GLPK", EntryPoint = "glp_ios_row_attr")]
    public static partial void IosRowAttr(IntPtr T, int i, ref Attr attr);

    // determine current size of the cut pool
    [LibraryImport("GLPK", EntryPoint = "glp_ios_pool_size")]
    public static partial int IosPoolSize(IntPtr T);

    // add row (constraint) to the cut pool
    [LibraryImport("GLPK", EntryPoint = "glp_ios_add_row")]
    public static partial int IosAddRow(IntPtr T, IntPtr name, int klass, int flags, int len, int[] ind, double[] val,
        int type, double rhs);

    // remove row (constraint) from the cut pool
    [LibraryImport("GLPK", EntryPoint = "glp_ios_del_row")]
    public static partial void IosDelRow(IntPtr T, int i);

    // remove all rows (constraints) from the cut pool
    [LibraryImport("GLPK", EntryPoint = "glp_ios_clear_pool")]
    public static partial void IosClearPool(IntPtr T);

    // check if can branch upon specified variable
    [LibraryImport("GLPK", EntryPoint = "glp_ios_can_branch")]
    public static partial int IosCanBranch(IntPtr T, int j);

    // choose variable to branch upon
    [LibraryImport("GLPK", EntryPoint = "glp_ios_branch_upon")]
    public static partial void IosBranchUpon(IntPtr T, int j, int sel);

    // select subproblem to continue the search
    [LibraryImport("GLPK", EntryPoint = "glp_ios_select_node")]
    public static partial void IosSelectNode(IntPtr T, int p);

    // provide solution found by heuristic
    [LibraryImport("GLPK", EntryPoint = "glp_ios_heur_sol")]
    public static partial int IosHeurSol(IntPtr T, double[] x);

    // terminate the solution process
    [LibraryImport("GLPK", EntryPoint = "glp_ios_terminate")]
    public static partial void IosTerminate(IntPtr T);

    // generate Gomory's mixed integer cut (core routine)
    [LibraryImport("GLPK", EntryPoint = "glp_gmi_cut")]
    public static partial int GmiCut(IntPtr prob, int j, int[] ind, double[] val, double[] phi);

    // generate Gomory's mixed integer cuts
    [LibraryImport("GLPK", EntryPoint = "glp_gmi_gen")]
    public static partial int GmiGen(IntPtr prob, IntPtr pool, int max_cuts);

    // create and initialize cover cut generator
    [LibraryImport("GLPK", EntryPoint = "glp_cov_init")]
    public static partial IntPtr CovInit(IntPtr prob);

    // generate locally valid simple cover cuts
    [LibraryImport("GLPK", EntryPoint = "glp_cov_gen1")]
    public static partial void CovGen1(IntPtr prob, IntPtr cov, IntPtr pool);

    // delete cover cut generator workspace
    [LibraryImport("GLPK", EntryPoint = "glp_cov_free")]
    public static partial void CovFree(IntPtr cov);

    // create and initialize MIR cut generator
    [LibraryImport("GLPK", EntryPoint = "glp_mir_init")]
    public static partial IntPtr MirInit(IntPtr prob);

    // generate mixed integer rounding (MIR) cuts
    [LibraryImport("GLPK", EntryPoint = "glp_mir_gen")]
    public static partial int MirGen(IntPtr prob, IntPtr mir, IntPtr pool);

    // delete MIR cut generator workspace
    [LibraryImport("GLPK", EntryPoint = "glp_mir_free")]
    public static partial void MirFree(IntPtr mir);

    // create and initialize conflict graph
    [LibraryImport("GLPK", EntryPoint = "glp_cfg_init")]
    public static partial IntPtr CfgInit(IntPtr prob);

    // delete conflict graph descriptor
    [LibraryImport("GLPK", EntryPoint = "glp_cfg_free")]
    public static partial void CfgFree(IntPtr cfg);

    // generate clique cut from conflict graph
    [LibraryImport("GLPK", EntryPoint = "glp_clq_cut")]
    public static partial int ClqCut(IntPtr prob, IntPtr cfg, int[] ind, double[] val);

    // initialize MPS format control parameters
    [LibraryImport("GLPK", EntryPoint = "glp_init_mpscp")]
    public static partial void InitMpscp(out MPSCP parm);

    // read problem data in MPS format
    [LibraryImport("GLPK", EntryPoint = "glp_read_mps")]
    public static partial int ReadMps(IntPtr prob, int fmt, ref MPSCP parm, IntPtr fname);

    // write problem data in MPS format
    [LibraryImport("GLPK", EntryPoint = "glp_write_mps")]
    public static partial int WriteMps(IntPtr prob, int fmt, ref MPSCP parm, IntPtr fname);

    // initialize CPLEX LP format control parameters
    [LibraryImport("GLPK", EntryPoint = "glp_init_cpxcp")]
    public static partial void InitCpxcp(out CPXCP parm);

    // read problem data in CPLEX LP format
    [LibraryImport("GLPK", EntryPoint = "glp_read_lp")]
    public static partial int ReadLp(IntPtr prob, ref CPXCP parm, IntPtr fname);

    // write problem data in CPLEX LP format
    [LibraryImport("GLPK", EntryPoint = "glp_write_lp")]
    public static partial int WriteLp(IntPtr prob, ref CPXCP parm, IntPtr fname);

    // read problem data in GLPK format
    [LibraryImport("GLPK", EntryPoint = "glp_read_prob")]
    public static partial int ReadProb(IntPtr prob, int flags, IntPtr fname);

    // write problem data in GLPK format
    [LibraryImport("GLPK", EntryPoint = "glp_write_prob")]
    public static partial int WriteProb(IntPtr prob, int flags, IntPtr fname);

    // allocate the MathProg translator workspace
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_alloc_wksp")]
    public static partial IntPtr MplAllocWksp();

    // initialize pseudo-random number generator
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_init_rand")]
    public static partial void MplInitRand(IntPtr tran, int seed);

    // read and translate model section
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_read_model")]
    public static partial int MplReadModel(IntPtr tran, IntPtr fname, int skip);

    // read and translate data section
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_read_data")]
    public static partial int MplReadData(IntPtr tran, IntPtr fname);

    // generate the model
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_generate")]
    public static partial int MplGenerate(IntPtr tran, IntPtr fname);

    // build LP/MIP problem instance from the model
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_build_prob")]
    public static partial void MplBuildProb(IntPtr tran, IntPtr prob);

    // postsolve the model
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_postsolve")]
    public static partial int MplPostsolve(IntPtr tran, IntPtr prob, int sol);

    // free the MathProg translator workspace
    [LibraryImport("GLPK", EntryPoint = "glp_mpl_free_wksp")]
    public static partial void MplFreeWksp(IntPtr tran);

    // read CNF-SAT problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_read_cnfsat")]
    public static partial int ReadCnfsat(IntPtr prob, IntPtr fname);

    // check for CNF-SAT problem instance
    [LibraryImport("GLPK", EntryPoint = "glp_check_cnfsat")]
    public static partial int CheckCnfsat(IntPtr prob);

    // write CNF-SAT problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_write_cnfsat")]
    public static partial int WriteCnfsat(IntPtr prob, IntPtr fname);

    // solve CNF-SAT problem with MiniSat solver
    [LibraryImport("GLPK", EntryPoint = "glp_minisat1")]
    public static partial int Minisat1(IntPtr prob);

    // solve integer feasibility problem
    [LibraryImport("GLPK", EntryPoint = "glp_intfeas1")]
    public static partial int Intfeas1(IntPtr prob, int use_bound, int obj_bound);

    // initialize GLPK environment
    [LibraryImport("GLPK", EntryPoint = "glp_init_env")]
    public static partial int InitEnv();

    // determine library version
    [LibraryImport("GLPK", EntryPoint = "glp_version")]
    public static partial IntPtr Version();

    // determine library configuration
    [LibraryImport("GLPK", EntryPoint = "glp_config")]
    public static partial IntPtr Config(IntPtr option);

    // free GLPK environment
    [LibraryImport("GLPK", EntryPoint = "glp_free_env")]
    public static partial int FreeEnv();

    // enable/disable terminal output
    [LibraryImport("GLPK", EntryPoint = "glp_term_out")]
    public static partial int TermOut(int flag);

    // check for error state
    [LibraryImport("GLPK", EntryPoint = "glp_at_error")]
    public static partial int AtError();

    // set memory usage limit
    [LibraryImport("GLPK", EntryPoint = "glp_mem_limit")]
    public static partial void MemLimit(int limit);

    // get memory usage information
    [LibraryImport("GLPK", EntryPoint = "glp_mem_usage")]
    public static partial void MemUsage(ref int count, ref int cpeak, IntPtr total, IntPtr tpeak);

    // determine current universal time
    [LibraryImport("GLPK", EntryPoint = "glp_time")]
    public static partial double Time();

    // compute difference between two time values
    [LibraryImport("GLPK", EntryPoint = "glp_difftime")]
    public static partial double Difftime(double t1, double t0);

    // create graph
    [LibraryImport("GLPK", EntryPoint = "glp_create_graph")]
    public static partial IntPtr CreateGraph(int v_size, int a_size);

    // assign (change) graph name
    [LibraryImport("GLPK", EntryPoint = "glp_set_graph_name")]
    public static partial void SetGraphName(ref Graph graph, IntPtr name);

    // add new vertices to graph
    [LibraryImport("GLPK", EntryPoint = "glp_add_vertices")]
    public static partial int AddVertices(ref Graph graph, int nadd);

    // assign (change) vertex name
    [LibraryImport("GLPK", EntryPoint = "glp_set_vertex_name")]
    public static partial void SetVertexName(ref Graph graph, int i, IntPtr name);

    // add new arc to graph
    [LibraryImport("GLPK", EntryPoint = "glp_add_arc")]
    public static partial IntPtr AddArc(ref Graph graph, int i, int j);

    // delete vertices from graph
    [LibraryImport("GLPK", EntryPoint = "glp_del_vertices")]
    public static partial void DelVertices(ref Graph graph, int ndel, int[] num);

    // delete arc from graph
    [LibraryImport("GLPK", EntryPoint = "glp_del_arc")]
    public static partial void DelArc(ref Graph graph, ref Arc a);

    // erase graph content
    [LibraryImport("GLPK", EntryPoint = "glp_erase_graph")]
    public static partial void EraseGraph(ref Graph graph, int v_size, int a_size);

    // delete graph
    [LibraryImport("GLPK", EntryPoint = "glp_delete_graph")]
    public static partial void DeleteGraph(ref Graph graph);

    // create vertex name index
    [LibraryImport("GLPK", EntryPoint = "glp_create_v_index")]
    public static partial void CreateVIndex(ref Graph graph);

    // find vertex by its name
    [LibraryImport("GLPK", EntryPoint = "glp_find_vertex")]
    public static partial int FindVertex(ref Graph graph, IntPtr name);

    // delete vertex name index
    [LibraryImport("GLPK", EntryPoint = "glp_delete_v_index")]
    public static partial void DeleteVIndex(ref Graph graph);

    // read graph from plain text file
    [LibraryImport("GLPK", EntryPoint = "glp_read_graph")]
    public static partial int ReadGraph(ref Graph graph, IntPtr fname);

    // write graph to plain text file
    [LibraryImport("GLPK", EntryPoint = "glp_write_graph")]
    public static partial int WriteGraph(ref Graph graph, IntPtr fname);

    // convert minimum cost flow problem to LP
    [LibraryImport("GLPK", EntryPoint = "glp_mincost_lp")]
    public static partial void MincostLp(IntPtr prob, ref Graph graph, int names, int v_rhs, int a_low, int a_cap,
        int a_cost);

    // find minimum-cost flow with out-of-kilter algorithm
    [LibraryImport("GLPK", EntryPoint = "glp_mincost_okalg")]
    public static partial int MincostOkalg(ref Graph graph, int v_rhs, int a_low, int a_cap, int a_cost, ref double sol,
        int a_x, int v_pi);

    // find minimum-cost flow with Bertsekas-Tseng relaxation method
    [LibraryImport("GLPK", EntryPoint = "glp_mincost_relax4")]
    public static partial int MincostRelax4(ref Graph graph, int v_rhs, int a_low, int a_cap, int a_cost, int crash,
        ref double sol, int a_x, int a_rc);

    // convert maximum flow problem to LP
    [LibraryImport("GLPK", EntryPoint = "glp_maxflow_lp")]
    public static partial void MaxflowLp(IntPtr prob, ref Graph graph, int names, int s, int t, int a_cap);

    // find maximal flow with Ford-Fulkerson algorithm
    [LibraryImport("GLPK", EntryPoint = "glp_maxflow_ffalg")]
    public static partial int MaxflowFfalg(ref Graph graph, int s, int t, int a_cap, ref double sol, int a_x,
        int v_cut);

    // check correctness of assignment problem data
    [LibraryImport("GLPK", EntryPoint = "glp_check_asnprob")]
    public static partial int CheckAsnprob(ref Graph graph, int v_set);

    // convert assignment problem to LP
    [LibraryImport("GLPK", EntryPoint = "glp_asnprob_lp")]
    public static partial int AsnprobLp(IntPtr prob, int form, ref Graph graph, int names, int v_set, int a_cost);

    // solve assignment problem with out-of-kilter algorithm
    [LibraryImport("GLPK", EntryPoint = "glp_asnprob_okalg")]
    public static partial int AsnprobOkalg(int form, ref Graph graph, int v_set, int a_cost, ref double sol, int a_x);

    // find bipartite matching of maximum cardinality
    [LibraryImport("GLPK", EntryPoint = "glp_asnprob_hall")]
    public static partial int AsnprobHall(ref Graph graph, int v_set, int a_x);

    // solve critical path problem
    [LibraryImport("GLPK", EntryPoint = "glp_cpp")]
    public static partial double Cpp(ref Graph graph, int v_t, int v_es, int v_ls);

    // read min-cost flow problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_read_mincost")]
    public static partial int ReadMincost(ref Graph graph, int v_rhs, int a_low, int a_cap, int a_cost, IntPtr fname);

    // write min-cost flow problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_write_mincost")]
    public static partial int WriteMincost(ref Graph graph, int v_rhs, int a_low, int a_cap, int a_cost, IntPtr fname);

    // read maximum flow problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_read_maxflow")]
    public static partial int ReadMaxflow(ref Graph graph, ref int s, ref int t, int a_cap, IntPtr fname);

    // write maximum flow problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_write_maxflow")]
    public static partial int WriteMaxflow(ref Graph graph, int s, int t, int a_cap, IntPtr fname);

    // read assignment problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_read_asnprob")]
    public static partial int ReadAsnprob(ref Graph graph, int v_set, int a_cost, IntPtr fname);

    // write assignment problem data in DIMACS format
    [LibraryImport("GLPK", EntryPoint = "glp_write_asnprob")]
    public static partial int WriteAsnprob(ref Graph graph, int v_set, int a_cost, IntPtr fname);

    // read graph in DIMACS clique/coloring format
    [LibraryImport("GLPK", EntryPoint = "glp_read_ccdata")]
    public static partial int ReadCcdata(ref Graph graph, int v_wgt, IntPtr fname);

    // write graph in DIMACS clique/coloring format
    [LibraryImport("GLPK", EntryPoint = "glp_write_ccdata")]
    public static partial int WriteCcdata(ref Graph graph, int v_wgt, IntPtr fname);

    // Klingman's network problem generator
    [LibraryImport("GLPK", EntryPoint = "glp_netgen")]
    public static partial int Netgen(ref Graph graph, int v_rhs, int a_cap, int a_cost, int[] parm);

    // Klingman's standard network problem instance
    [LibraryImport("GLPK", EntryPoint = "glp_netgen_prob")]
    public static partial void NetgenProb(int nprob, int[] parm);

    // grid-like network problem generator
    [LibraryImport("GLPK", EntryPoint = "glp_gridgen")]
    public static partial int Gridgen(ref Graph graph, int v_rhs, int a_cap, int a_cost, int[] parm);

    // Goldfarb's maximum flow problem generator
    [LibraryImport("GLPK", EntryPoint = "glp_rmfgen")]
    public static partial int Rmfgen(ref Graph graph, ref int s, ref int t, int a_cap, int[] parm);

    // find all weakly connected components of graph
    [LibraryImport("GLPK", EntryPoint = "glp_weak_comp")]
    public static partial int WeakComp(ref Graph graph, int v_num);

    // find all strongly connected components of graph
    [LibraryImport("GLPK", EntryPoint = "glp_strong_comp")]
    public static partial int StrongComp(ref Graph graph, int v_num);

    // topological sorting of acyclic digraph
    [LibraryImport("GLPK", EntryPoint = "glp_top_sort")]
    public static partial int TopSort(ref Graph graph, int v_num);

    // find maximum weight clique with exact algorithm
    [LibraryImport("GLPK", EntryPoint = "glp_wclique_exact")]
    public static partial int WcliqueExact(ref Graph graph, int v_wgt, ref double sol, int v_set);
}
