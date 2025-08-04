namespace UniMZ.GLPK;

public static partial class GLPK
{
    // library version numbers:
    public const int MAJOR_VERSION = 5;
    public const int MINOR_VERSION = 0;

    // optimization direction flag:
    public const int MIN = 1; // minimization
    public const int MAX = 2; // maximization

    // kind of structural variable:
    public const int CV = 1; // continuous variable
    public const int IV = 2; // integer variable
    public const int BV = 3; // binary variable

    // type of auxiliary/structural variable:
    public const int FR = 1; // free (unbounded) variable
    public const int LO = 2; // variable with lower bound
    public const int UP = 3; // variable with upper bound
    public const int DB = 4; // double-bounded variable
    public const int FX = 5; // fixed variable

    // status of auxiliary/structural variable:
    public const int BS = 1; // basic variable
    public const int NL = 2; // non-basic variable on lower bound
    public const int NU = 3; // non-basic variable on upper bound
    public const int NF = 4; // non-basic free (unbounded) variable
    public const int NS = 5; // non-basic fixed variable

    // scaling options:
    public const int SF_GM = 0x01; // perform geometric mean scaling
    public const int SF_EQ = 0x10; // perform equilibration scaling
    public const int SF_2N = 0x20; // round scale factors to power of two
    public const int SF_SKIP = 0x40; // skip if problem is well scaled
    public const int SF_AUTO = 0x80; // choose scaling options automatically

    // solution indicator:
    public const int SOL = 1; // basic solution
    public const int IPT = 2; // interior-point solution
    public const int MIP = 3; // mixed integer solution

    // solution status:
    public const int UNDEF = 1; // solution is undefined
    public const int FEAS = 2; // solution is feasible
    public const int INFEAS = 3; // solution is infeasible
    public const int NOFEAS = 4; // no feasible solution exists
    public const int OPT = 5; // solution is optimal
    public const int UNBND = 6; // solution is unbounded

    // enable/disable flag:
    public const int ON = 1; // enable something
    public const int OFF = 0; // disable something

    // reason codes:
    public const int IROWGEN = 0x01; // request for row generation
    public const int IBINGO = 0x02; // better integer solution found
    public const int IHEUR = 0x03; // request for heuristic solution
    public const int ICUTGEN = 0x04; // request for cut generation
    public const int IBRANCH = 0x05; // request for branching
    public const int ISELECT = 0x06; // request for subproblem selection
    public const int IPREPRO = 0x07; // request for preprocessing

    // branch selection indicator:
    public const int NO_BRNCH = 0; // select no branch
    public const int DN_BRNCH = 1; // select down-branch
    public const int UP_BRNCH = 2; // select up-branch

    // return codes:
    public const int EBADB = 0x01; // invalid basis
    public const int ESING = 0x02; // singular matrix
    public const int ECOND = 0x03; // ill-conditioned matrix
    public const int EBOUND = 0x04; // invalid bounds
    public const int EFAIL = 0x05; // solver failed
    public const int EOBJLL = 0x06; // objective lower limit reached
    public const int EOBJUL = 0x07; // objective upper limit reached
    public const int EITLIM = 0x08; // iteration limit exceeded
    public const int ETMLIM = 0x09; // time limit exceeded
    public const int ENOPFS = 0x0A; // no primal feasible solution
    public const int ENODFS = 0x0B; // no dual feasible solution
    public const int EROOT = 0x0C; // root LP optimum not provided
    public const int ESTOP = 0x0D; // search terminated by application
    public const int EMIPGAP = 0x0E; // relative mip gap tolerance reached
    public const int ENOFEAS = 0x0F; // no primal/dual feasible solution
    public const int ENOCVG = 0x10; // no convergence
    public const int EINSTAB = 0x11; // numerical instability
    public const int EDATA = 0x12; // invalid data
    public const int ERANGE = 0x13; // result out of range

    // condition indicator:
    public const int KKT_PE = 1; // primal equalities
    public const int KKT_PB = 2; // primal bounds
    public const int KKT_DE = 3; // dual equalities
    public const int KKT_DB = 4; // dual bounds
    public const int KKT_CS = 5; // complementary slackness

    // MPS file format:
    public const int MPS_DECK = 1; // fixed (ancient)
    public const int MPS_FILE = 2; // free (modern)

    // assignment problem formulation:
    public const int ASN_MIN = 1; // perfect matching (minimization)
    public const int ASN_MAX = 2; // perfect matching (maximization)
    public const int ASN_MMP = 3; // maximum matching

    // basis factorization control parameters
    // factorization type:
    public const int BF_LUF = 0x00; // plain LU-factorization
    public const int BF_BTF = 0x10; // block triangular LU-factorization
    public const int BF_FT = 0x01; // Forrest-Tomlin (LUF only)
    public const int BF_BG = 0x02; // Schur compl. + Bartels-Golub
    public const int BF_GR = 0x03; // Schur compl. + Givens rotation

    // simplex solver control parameters
    // message level:
    public const int MSG_OFF = 0; // no output
    public const int MSG_ERR = 1; // warning and error messages only
    public const int MSG_ON = 2; // normal output
    public const int MSG_ALL = 3; // full output
    public const int MSG_DBG = 4; // debug output

    // simplex method option:
    public const int PRIMAL = 1; // use primal simplex
    public const int DUALP = 2; // use dual; if it fails, use primal
    public const int DUAL = 3; // use dual simplex

    // pricing technique:
    public const int PT_STD = 0x11; // standard (Dantzig's rule)
    public const int PT_PSE = 0x22; // projected steepest edge

    // ratio test technique:
    public const int RT_STD = 0x11; // standard (textbook)
    public const int RT_HAR = 0x22; // Harris' two-pass ratio test
    public const int RT_FLIP = 0x33; // long-step (flip-flop) ratio test

    // option to use A or N:
    public const int USE_AT = 1; // use A matrix in row-wise format
    public const int USE_NT = 2; // use N matrix in row-wise format

    // interior-point solver control parameters
    // ordering algorithm:
    public const int ORD_NONE = 0; // natural (original) ordering
    public const int ORD_QMD = 1; // quotient minimum degree (QMD)
    public const int ORD_AMD = 2; // approx. minimum degree (AMD)
    public const int ORD_SYMAMD = 3; // approx. minimum degree (SYMAMD)

    // integer optimizer control parameters
    // branching technique:
    public const int BR_FFV = 1; // first fractional variable
    public const int BR_LFV = 2; // last fractional variable
    public const int BR_MFV = 3; // most fractional variable
    public const int BR_DTH = 4; // heuristic by Driebeck and Tomlin
    public const int BR_PCH = 5; // hybrid pseudocost heuristic

    // backtracking technique:
    public const int BT_DFS = 1; // depth first search
    public const int BT_BFS = 2; // breadth first search
    public const int BT_BLB = 3; // best local bound
    public const int BT_BPH = 4; // best projection heuristic

    // preprocessing technique:
    public const int PP_NONE = 0; // disable preprocessing
    public const int PP_ROOT = 1; // preprocessing only on root level
    public const int PP_ALL = 2; // preprocessing on all levels

    // additional row attributes
    // row origin flag:
    public const int RF_REG = 0; // regular constraint
    public const int RF_LAZY = 1; // "lazy" constraint
    public const int RF_CUT = 2; // cutting plane constraint

    // row class descriptor:
    public const int RF_GMI = 1; // Gomory's mixed integer cut
    public const int RF_MIR = 2; // mixed integer rounding cut
    public const int RF_COV = 3; // mixed cover cut
    public const int RF_CLQ = 4; // clique cut
}
