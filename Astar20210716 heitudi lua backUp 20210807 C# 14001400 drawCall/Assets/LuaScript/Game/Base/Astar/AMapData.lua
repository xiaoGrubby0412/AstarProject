---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by wangman.
--- DateTime: 2021/7/21 16:07
---

---@class AMapData:AMapDataBase
---@field blockData number[][]
---@field mapWidth number
---@field mapHeight number
local AMapData = Class("AMapData", require("Game.Base.Astar.AMapDataBase"))

function AMapData:ctor(mapWidth, mapHeight)
    self.super:ctor(mapWidth, mapHeight)
end

---@type AMapData
AMapDataManager = AMapData.New()
