// Copyright (c) 2024-2026 The FluentFlyout Authors
// SPDX-License-Identifier: GPL-3.0-or-later

namespace FluentFlyoutWPF.Classes.Utils;

public static class StartupCommandFormatter
{
    public static string FormatExecutablePath(string executablePath)
    {
        string normalizedPath = executablePath.Trim().Trim('"');
        return $"\"{normalizedPath}\"";
    }
}