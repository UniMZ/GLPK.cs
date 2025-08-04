namespace UniMZ.GLPKTest;

using UniMZ.GLPK;

[TestClass]
public class GLPKTest
{
    [TestMethod]
    public void TestCreateProb() { GLPK.DeleteProb(GLPK.CreateProb()); }

    [TestMethod]
    public void TestLP()
    {
        var prob = GLPK.CreateProb();
        Assert.AreEqual(1, GLPK.AddRows(prob, 2));
        Assert.AreEqual(1, GLPK.AddCols(prob, 3));

        // max x1 + 2 x2 + x3
        GLPK.SetObjCoef(prob, 1, 1);
        GLPK.SetObjCoef(prob, 2, 2);
        GLPK.SetObjCoef(prob, 3, 1);
        GLPK.SetObjDir(prob, GLPK.MAX);

        GLPK.SetColBnds(prob, 1, GLPK.LO, 0, 0); // 0 <= x1
        GLPK.SetColBnds(prob, 2, GLPK.LO, 0, 0); // 0 <= x2
        GLPK.SetColBnds(prob, 3, GLPK.DB, 0, 2); // 0 <= x3 <= 2

        GLPK.SetRowBnds(prob, 1, GLPK.DB, 0, 2); // 0 <= x1 + x2 <= 2
        GLPK.SetRowBnds(prob, 2, GLPK.DB, 0, 1); // 0 <= x1 - x2 <= 1

        // GLPK use 1-based array and the first item will be ignored
        GLPK.SetMatRow(prob, 1, 2, [0, 1, 2], [0, 1.0, 1.0]); // x1 + x2
        GLPK.SetMatRow(prob, 2, 2, [0, 1, 2], [0, 1.0, -1.0]); // x1 + x2

        GLPK.InitSmcp(out var cfg);
        cfg.presolve = GLPK.ON;
        Assert.AreEqual(0, GLPK.Simplex(prob, ref cfg));
        Assert.AreEqual(GLPK.OPT, GLPK.GetStatus(prob));

        Assert.AreEqual(1, GLPK.GetColPrim(prob, 1));
        Assert.AreEqual(1, GLPK.GetColPrim(prob, 2));
        Assert.AreEqual(2, GLPK.GetColPrim(prob, 3));
        Assert.AreEqual(5, GLPK.GetObjVal(prob));

        GLPK.DeleteProb(prob);
    }
}
