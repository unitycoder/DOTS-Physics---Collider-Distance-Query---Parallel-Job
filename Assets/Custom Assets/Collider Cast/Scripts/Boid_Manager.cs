﻿using Unity.Entities;

public struct Boid_Manager 
{
    public float cohesionBias;
    public float separationBias;
    public float alignmentBias;
    public float targetBias;
    public float perceptionRadius;
    public float step;
    public int cellSize;
    public float fieldOfView;
    public int maxPercived;
    public float maxObstacleDistance;
}

public struct BoidManagerBLOB
{
    public BlobArray<Boid_Manager> blobManagerArray;
}
