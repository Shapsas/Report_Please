﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageBug : Bug
{
    private string package;
    private string packageVersion;

    public PackageBug(string title, int caseID, string testerName, AreasNGrabbags area,
        string reproSteps, string expectActual, string reproWith,
    bool regression, string FAV, bool publicField, int severity, int platform, int user,
    string package, string packageVersion, Tester tester, Discrepancy discrepancy, int correctSeverity,
    int correctPlatform)
    {
        this.title = title;
        this.caseID = caseID;
        this.testerName = testerName;
        this.area = area;

        this.reproSteps = reproSteps;
        expectedActualResults = expectActual;
        reproNoReproWith = reproWith;

        this.regression = regression;
        this.FAV = FAV;
        this.publicField = publicField;

        this.severity = severity;
        platformImportance = platform;
        userPrevalence = user;

        this.package = package;
        this.packageVersion = packageVersion;
        this.tester = tester;
        this.discrepancy = discrepancy;
        this.correctSeverity = correctSeverity;
        this.correctPlatform = correctPlatform;
    }

    public override ReportType GetReportType()
    {
        return ReportType.PackageBug;
    }

    public string GetPackage()
    {
        return package;
    }

    public string GetPackageVersion()
    {
        return packageVersion;
    }

    public override Discrepancy GetDiscrepancy()
    {
        return discrepancy;
    }

    public void SetPackageVersion(string version)
    {
        packageVersion = version;
    }

    public void SetPackageName(string package)
    {
        this.package = package;
    }
}
