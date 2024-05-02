<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: src/proto/grpc/testing/stats.proto

namespace Grpc\Testing;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Histogram params based on grpc/support/histogram.c
 *
 * Generated from protobuf message <code>grpc.testing.HistogramParams</code>
 */
class HistogramParams extends \Google\Protobuf\Internal\Message
{
    /**
     * first bucket is [0, 1 + resolution)
     *
     * Generated from protobuf field <code>double resolution = 1;</code>
     */
    protected $resolution = 0.0;
    /**
     * use enough buckets to allow this value
     *
     * Generated from protobuf field <code>double max_possible = 2;</code>
     */
    protected $max_possible = 0.0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type float $resolution
     *           first bucket is [0, 1 + resolution)
     *     @type float $max_possible
     *           use enough buckets to allow this value
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Src\Proto\Grpc\Testing\Stats::initOnce();
        parent::__construct($data);
    }

    /**
     * first bucket is [0, 1 + resolution)
     *
     * Generated from protobuf field <code>double resolution = 1;</code>
     * @return float
     */
    public function getResolution()
    {
        return $this->resolution;
    }

    /**
     * first bucket is [0, 1 + resolution)
     *
     * Generated from protobuf field <code>double resolution = 1;</code>
     * @param float $var
     * @return $this
     */
    public function setResolution($var)
    {
        GPBUtil::checkDouble($var);
        $this->resolution = $var;

        return $this;
    }

    /**
     * use enough buckets to allow this value
     *
     * Generated from protobuf field <code>double max_possible = 2;</code>
     * @return float
     */
    public function getMaxPossible()
    {
        return $this->max_possible;
    }

    /**
     * use enough buckets to allow this value
     *
     * Generated from protobuf field <code>double max_possible = 2;</code>
     * @param float $var
     * @return $this
     */
    public function setMaxPossible($var)
    {
        GPBUtil::checkDouble($var);
        $this->max_possible = $var;

        return $this;
    }

}

